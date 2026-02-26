using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B88 RID: 2952
	[Token(Token = "0x2000B88")]
	public class BossCaptainRatingData
	{
		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047BC RID: 18364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E59")]
		public CaptainRating RawCaptainRating
		{
			[Token(Token = "0x60047BB")]
			[Address(RVA = "0x9646", Offset = "0x9646", VA = "0x9646")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047BC")]
			[Address(RVA = "0x9647", Offset = "0x9647", VA = "0x9647")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5A")]
		public List<ulong> MyTeamIds
		{
			[Token(Token = "0x60047BD")]
			[Address(RVA = "0x9648", Offset = "0x9648", VA = "0x9648")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047BE")]
			[Address(RVA = "0x9649", Offset = "0x9649", VA = "0x9649")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x17000E5B")]
		public ulong Score
		{
			[Token(Token = "0x60047BF")]
			[Address(RVA = "0x964A", Offset = "0x964A", VA = "0x964A")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060047C0 RID: 18368 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x17000E5C")]
		public ulong Place
		{
			[Token(Token = "0x60047C0")]
			[Address(RVA = "0x964B", Offset = "0x964B", VA = "0x964B")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x17000E5D")]
		public ulong CaptainId
		{
			[Token(Token = "0x60047C1")]
			[Address(RVA = "0x964C", Offset = "0x964C", VA = "0x964C")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060047C2 RID: 18370 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x17000E5E")]
		public bool IsMyCaptain
		{
			[Token(Token = "0x60047C2")]
			[Address(RVA = "0x964D", Offset = "0x964D", VA = "0x964D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5F")]
		public bool IsAlive
		{
			[Token(Token = "0x60047C3")]
			[Address(RVA = "0x964E", Offset = "0x964E", VA = "0x964E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047C4")]
			[Address(RVA = "0x964F", Offset = "0x964F", VA = "0x964F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E60")]
		[CanBeNull]
		public UserData CaptainUserData
		{
			[Token(Token = "0x60047C5")]
			[Address(RVA = "0x9650", Offset = "0x9650", VA = "0x9650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60047C6")]
			[Address(RVA = "0x9651", Offset = "0x9651", VA = "0x9651")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001C8 RID: 456
		// (add) Token: 0x060047C7 RID: 18375 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060047C8 RID: 18376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C8")]
		public event Action CaptainUserDataChangedEvent
		{
			[Token(Token = "0x60047C7")]
			[Address(RVA = "0x9652", Offset = "0x9652", VA = "0x9652")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60047C8")]
			[Address(RVA = "0x9653", Offset = "0x9653", VA = "0x9653")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x9654", Offset = "0x9654", VA = "0x9654")]
		public BossCaptainRatingData(CaptainRating captainRating, List<ulong> myTeamIds, bool isAlive)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Model_BossCaptainRatingData___ctor
		               (int param1,undefined8 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x14) = *(undefined4 *)(param3 + 0x10);
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060047CA RID: 18378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x9655", Offset = "0x9655", VA = "0x9655")]
		private void ResultCallback(long operationIndex, UserData[] data)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MyTeamIds ---
		undefined8 Gameplay_Boss_Model_BossCaptainRatingData__set_MyTeamIds(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 8) + 0x18);
		}
		*/


		/* --- GHIDRA: get_Score ---
		undefined8 Gameplay_Boss_Model_BossCaptainRatingData__get_Score(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 8) + 0x20);
		}
		*/


		/* --- GHIDRA: get_CaptainId ---
		uint Gameplay_Boss_Model_BossCaptainRatingData__get_CaptainId(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a73 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		    DAT_ram_00a57a73 = '\x01';
		  }
		  return (uint)(0 < *(int *)(*(int *)(param1 + 0xc) + 0xc));
		}
		*/


		/* --- GHIDRA: set_CaptainUserData ---
		void Gameplay_Boss_Model_BossCaptainRatingData__set_CaptainUserData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57a74 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57a74 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
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


		/* --- GHIDRA: add_CaptainUserDataChangedEvent ---
		void Gameplay_Boss_Model_BossCaptainRatingData__add_CaptainUserDataChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57a75 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57a75 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x18,param1_01,param1_00);
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


		/* --- GHIDRA: remove_CaptainUserDataChangedEvent ---
		void Gameplay_Boss_Model_BossCaptainRatingData__remove_CaptainUserDataChangedEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a57a76 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Boss_Model_BossCaptainRatingData_ResultCallback__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a57a76 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x10) = (undefined1)param4;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar6 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x80e1910b;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e1910b:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x80e191b7;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e191b7:
		  uVar6 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  piVar3 = (int *)Core_Gameplay_Managers_CacheManager__set_AudioClipCache
		                            (uVar2,*(undefined4 *)(iVar4 + 0x14),0);
		  uVar2 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (uVar2,param1,Method_Gameplay_Boss_Model_BossCaptainRatingData_ResultCallback__,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  *(undefined8 *)(iVar4 + 0x10) = *(undefined8 *)(*(int *)(param1 + 8) + 0x10);
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80e1927f;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x80e1927f:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar3,uVar2,iVar4,puVar1[1]);
		  return;
		}
		*/

}
