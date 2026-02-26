using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mycom.Tracker.Unity.Ads;
using Mycom.Tracker.Unity.Internal.Interfaces;

namespace Mycom.Tracker.Unity
{
	// Token: 0x0200133E RID: 4926
	[Token(Token = "0x200133E")]
	public static class MyTracker
	{
		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06007494 RID: 29844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177B")]
		public static string InstanceId
		{
			[Token(Token = "0x6007494")]
			[Address(RVA = "0xBE60", Offset = "0xBE60", VA = "0xBE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06007495 RID: 29845 RVA: 0x00014FD0 File Offset: 0x000131D0
		// (set) Token: 0x06007496 RID: 29846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700177C")]
		public static bool IsDebugMode
		{
			[Token(Token = "0x6007495")]
			[Address(RVA = "0xBE61", Offset = "0xBE61", VA = "0xBE61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007496")]
			[Address(RVA = "0xBE62", Offset = "0xBE62", VA = "0xBE62")]
			set
			{
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06007497 RID: 29847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177D")]
		public static MyTrackerParams MyTrackerParams
		{
			[Token(Token = "0x6007497")]
			[Address(RVA = "0xBE63", Offset = "0xBE63", VA = "0xBE63")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177E")]
		public static MyTrackerConfig MyTrackerConfig
		{
			[Token(Token = "0x6007498")]
			[Address(RVA = "0xBE64", Offset = "0xBE64", VA = "0xBE64")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007499")]
		[Address(RVA = "0xBE65", Offset = "0xBE65", VA = "0xBE65")]
		public static void Init(string id)
		{
		/* --- GHIDRA: Init ---
		void Mycom_Tracker_Unity_MyTracker__Init(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a596c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596c9 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x8104e4cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                5);
		code_r0x8104e4cd:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600749A RID: 29850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749A")]
		[Address(RVA = "0xBE66", Offset = "0xBE66", VA = "0xBE66")]
		public static void SetAttributionListener(Action<MyTrackerAttribution> listener)
		{
		/* --- GHIDRA: SetAttributionListener ---
		void Mycom_Tracker_Unity_MyTracker__SetAttributionListener
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a596ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596ca = '\x01';
		  }
		  iVar2 = func_ii_4769(param1,0);
		  if (iVar2 == 0) {
		    if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    }
		    param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf8);
		          goto code_r0x8104e5ad;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,7);
		code_r0x8104e5ad:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,param1,param2,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600749B RID: 29851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749B")]
		[Address(RVA = "0xBE67", Offset = "0xBE67", VA = "0xBE67")]
		public static void TrackEvent(string name, [Optional] IDictionary<string, string> eventParams)
		{
		/* --- GHIDRA: TrackEvent ---
		void Mycom_Tracker_Unity_MyTracker__TrackEvent(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a596cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596cb = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x8104e685;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                8);
		code_r0x8104e685:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600749C RID: 29852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749C")]
		[Address(RVA = "0xBE68", Offset = "0xBE68", VA = "0xBE68")]
		public static void TrackInviteEvent([Optional] IDictionary<string, string> eventParams)
		{
		/* --- GHIDRA: TrackInviteEvent ---
		void Mycom_Tracker_Unity_MyTracker__TrackInviteEvent
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int *param1_00;
		  int iVar2;
		  undefined8 uVar3;
		  uint uVar4;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a596cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596cc = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar4 = 0;
		  uVar3 = *param1;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0x108);
		        goto code_r0x8104e76c;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                9);
		code_r0x8104e76c:
		  local_10 = uVar3;
		  local_8 = uVar3;
		  (**(code **)((ulonglong)*puVar1 * 4))(param1_00,&local_10,param2,puVar1[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600749D RID: 29853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749D")]
		[Address(RVA = "0xBE69", Offset = "0xBE69", VA = "0xBE69")]
		public static void TrackLevelEvent([Optional] int? level, [Optional] IDictionary<string, string> eventParams)
		{
		/* --- GHIDRA: TrackLevelEvent ---
		void Mycom_Tracker_Unity_MyTracker__TrackLevelEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a596cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596cd = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x8104e85e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                10);
		code_r0x8104e85e:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,param2,param3,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600749E RID: 29854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749E")]
		[Address(RVA = "0xBE6A", Offset = "0xBE6A", VA = "0xBE6A")]
		public static void TrackLoginEvent(string userId, string vkConnectId, [Optional] IDictionary<string, string> eventParams)
		{
		/* --- GHIDRA: TrackLoginEvent ---
		void Mycom_Tracker_Unity_MyTracker__TrackLoginEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a596ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596ce = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x118);
		        goto code_r0x8104e937;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                0xb);
		code_r0x8104e937:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,param2,param3,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600749F RID: 29855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749F")]
		[Address(RVA = "0xBE6B", Offset = "0xBE6B", VA = "0xBE6B")]
		public static void TrackRegistrationEvent(string userId, string vkConnectId, [Optional] IDictionary<string, string> eventParams)
		{
		/* --- GHIDRA: TrackRegistrationEvent ---
		void Mycom_Tracker_Unity_MyTracker__TrackRegistrationEvent(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a596cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596cf = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x8104ea10;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                0xc);
		code_r0x8104ea10:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A0")]
		[Address(RVA = "0xBE6C", Offset = "0xBE6C", VA = "0xBE6C")]
		public static void TrackAdEvent(AdEvent adEvent)
		{
		/* --- GHIDRA: TrackAdEvent ---
		void Mycom_Tracker_Unity_MyTracker__TrackAdEvent(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a596d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596d0 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x128);
		        goto code_r0x8104eae5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                0xd);
		code_r0x8104eae5:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A1")]
		[Address(RVA = "0xBE6D", Offset = "0xBE6D", VA = "0xBE6D")]
		public static void Flush()
		{
		/* --- GHIDRA: Flush ---
		void Mycom_Tracker_Unity_MyTracker__Flush(undefined4 param1)
		
		{
		  if (DAT_ram_00a596d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596d1 = '\x01';
		  }
		  if (DAT_ram_00a59756 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo);
		    DAT_ram_00a59756 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo);
		  }
		  **(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c) =
		       **(undefined4 **)(Mycom_Tracker_Unity_Internal_Implementations_Fake_Tracker_TypeInfo + 0x5c);
		  return;
		}
		*/

		}

		// Token: 0x04003D35 RID: 15669
		[Token(Token = "0x4003D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ITracker Tracker;

		// Token: 0x04003D36 RID: 15670
		[Token(Token = "0x4003D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int State;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_InstanceId ---
		undefined4 Mycom_Tracker_Unity_MyTracker__get_InstanceId(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a596c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596c4 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8104df9f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                4);
		code_r0x8104df9f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_IsDebugMode ---
		void Mycom_Tracker_Unity_MyTracker__get_IsDebugMode(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a596c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596c5 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		        goto code_r0x8104e072;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                6);
		code_r0x8104e072:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/


		/* --- GHIDRA: set_IsDebugMode ---
		undefined4 Mycom_Tracker_Unity_MyTracker__set_IsDebugMode(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a596c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596c6 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8104e147;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                0);
		code_r0x8104e147:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_MyTrackerParams ---
		undefined4 Mycom_Tracker_Unity_MyTracker__get_MyTrackerParams(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a596c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596c7 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8104e21a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                1);
		code_r0x8104e21a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_MyTrackerConfig ---
		void Mycom_Tracker_Unity_MyTracker__get_MyTrackerConfig(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a596c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_LibraryLogger_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_SDKVersion_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24499);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11280);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11279);
		    DAT_ram_00a596c8 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  iVar2 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_int___AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebReadStream__ReadAsync_d__28_
		                    (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c) + 4,1,0,0);
		  iVar4 = Mycom_Tracker_Unity_LibraryLogger_TypeInfo;
		  if (iVar2 != 0) {
		    if (*(int *)(Mycom_Tracker_Unity_LibraryLogger_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Mycom_Tracker_Unity_LibraryLogger_TypeInfo);
		    }
		    Animations_InIdleOutSpineAnimation___ctor(StringLiteral_11279,iVar4);
		    return;
		  }
		  iVar2 = func_ii_4769(param1,0);
		  iVar4 = Mycom_Tracker_Unity_LibraryLogger_TypeInfo;
		  if (iVar2 != 0) {
		    if (*(int *)(Mycom_Tracker_Unity_LibraryLogger_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Mycom_Tracker_Unity_LibraryLogger_TypeInfo);
		    }
		    Animations_InIdleOutSpineAnimation___ctor(StringLiteral_24499,iVar4);
		    return;
		  }
		  if (*(int *)(Mycom_Tracker_Unity_SDKVersion_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_SDKVersion_TypeInfo);
		  }
		  param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                        (StringLiteral_11280,
		                         **(undefined4 **)(Mycom_Tracker_Unity_SDKVersion_TypeInfo + 0x5c),0);
		  if (*(int *)(Mycom_Tracker_Unity_LibraryLogger_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_LibraryLogger_TypeInfo);
		  }
		  Animations_InIdleOutSpineAnimation___ctor(param1_00,param1_00);
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  param1_01 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x8104e3f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                3);
		code_r0x8104e3f8:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1,puVar3[1]);
		  return;
		}
		*/

}
