using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Services;
using Utils;
using Utils.Timers;

namespace Core.Gameplay.Managers.Ad.Placements
{
	// Token: 0x02001209 RID: 4617
	[Token(Token = "0x2001209")]
	public class AdPlacementData : IAdPlacementData, IDisposable
	{
		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x17001645")]
		public uint AdPlacementId
		{
			[Token(Token = "0x6006D8E")]
			[Address(RVA = "0xB855", Offset = "0xB855", VA = "0xB855", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06006D8F RID: 28047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001646")]
		public string Name
		{
			[Token(Token = "0x6006D8F")]
			[Address(RVA = "0xB856", Offset = "0xB856", VA = "0xB856", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002DB RID: 731
		// (add) Token: 0x06006D90 RID: 28048 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D91 RID: 28049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DB")]
		public event Action<IAdPlacementData> BackTimerCompleteEvent
		{
			[Token(Token = "0x6006D90")]
			[Address(RVA = "0xB857", Offset = "0xB857", VA = "0xB857", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D91")]
			[Address(RVA = "0xB858", Offset = "0xB858", VA = "0xB858", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x17001647")]
		public bool IsAvailableByAppServer
		{
			[Token(Token = "0x6006D92")]
			[Address(RVA = "0xB859", Offset = "0xB859", VA = "0xB859", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D93")]
		[Address(RVA = "0x2246", Offset = "0x2246", VA = "0x2246")]
		public AdPlacementData(uint adPlacementId)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Gameplay_Managers_Ad_Placements_AdPlacementData___ctor
		              (undefined4 param1,int *param2,int *param3,undefined4 param4,undefined4 param5,
		              undefined4 param6,undefined4 param7)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  
		  if (DAT_ram_00a5a7b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a7b7 = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8126ecab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,2);
		code_r0x8126ecab:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar5 == 1) {
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x150);
		          goto code_r0x8126ed4b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8126ed4b:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		    uVar6 = *(undefined4 *)(iVar5 + 0x10);
		    uVar1 = 0;
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x8126edcc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8126edcc:
		    param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		    uVar1 = 0;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xf0);
		          goto code_r0x8126ee4a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,6);
		code_r0x8126ee4a:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if (DAT_ram_00a5a798 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents__Initialize__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager_TypeInfo
		                );
		      DAT_ram_00a5a798 = '\x01';
		    }
		    iVar5 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Ad_Placements_BattleFinish_BattleFinishAdPlacementManager_TypeInfo
		                      );
		    if (DAT_ram_00a5a794 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents___ctor__
		                );
		      DAT_ram_00a5a794 = '\x01';
		    }
		    Unity_Services_Core_Internal_DependencyTree___ctor
		              (iVar5,param2,param4,param5,param6,
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents___ctor__
		              );
		    *(undefined4 *)(iVar5 + 0x28) = uVar3;
		    *(undefined4 *)(iVar5 + 0x24) = uVar6;
		    puVar7 = &
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleFinishAdPlacementModel__BattleFinishAdPlacementController__BattleFinishAdPlacementEvents__Initialize__
		    ;
		  }
		  else if (iVar5 == 2) {
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x130);
		          goto code_r0x8126ef3e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x8126ef3e:
		    uVar1 = 0;
		    uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x8126efbe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8126efbe:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x160);
		          goto code_r0x8126f040;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x8126f040:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		    if (DAT_ram_00a5a7a1 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents__Initialize__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		                );
		      DAT_ram_00a5a7a1 = '\x01';
		    }
		    iVar5 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		                      );
		    if (DAT_ram_00a5a79d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents___ctor__
		                );
		      DAT_ram_00a5a79d = '\x01';
		    }
		    Unity_Services_Core_Internal_DependencyTree___ctor
		              (iVar5,param2,param4,param5,param6,
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents___ctor__
		              );
		    *(undefined4 *)(iVar5 + 0x2c) = uVar4;
		    *(undefined4 *)(iVar5 + 0x28) = uVar3;
		    *(undefined4 *)(iVar5 + 0x24) = uVar6;
		    puVar7 = &
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents__Initialize__
		    ;
		  }
		  else if (iVar5 == 3) {
		    if (DAT_ram_00a5a789 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents__Initialize__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		                );
		      DAT_ram_00a5a789 = '\x01';
		    }
		    iVar5 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		                      );
		    if (DAT_ram_00a5a785 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents___ctor__
		                );
		      DAT_ram_00a5a785 = '\x01';
		    }
		    Unity_Services_Core_Internal_DependencyTree___ctor
		              (iVar5,param2,param4,param5,param6,
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents___ctor__
		              );
		    puVar7 = &
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents__Initialize__
		    ;
		  }
		  else if (iVar5 == 4) {
		    if (DAT_ram_00a5a791 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents__Initialize__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		                );
		      DAT_ram_00a5a791 = '\x01';
		    }
		    iVar5 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Ad_Placements_DailyQuests_DailyQuestsAdPlacementManager_TypeInfo
		                      );
		    if (DAT_ram_00a5a78d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents___ctor__
		                );
		      DAT_ram_00a5a78d = '\x01';
		    }
		    Unity_Services_Core_Internal_DependencyTree___ctor
		              (iVar5,param2,param4,param5,param6,
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents___ctor__
		              );
		    puVar7 = &
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_DailyQuestsAdPlacementModel__DailyQuestsAdPlacementController__DailyQuestsAdPlacementEvents__Initialize__
		    ;
		  }
		  else {
		    if ((((iVar5 != 5) && (iVar5 != 6)) && (iVar5 != 7)) &&
		       (((iVar5 != 8 && (iVar5 != 9)) && ((iVar5 != 10 && (iVar5 != 0xb)))))) {
		      return 0;
		    }
		    if (DAT_ram_00a5a7b1 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents__Initialize__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		                );
		      DAT_ram_00a5a7b1 = '\x01';
		    }
		    iVar5 = unnamed_function_1417
		                      (
		                      Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		                      );
		    if (DAT_ram_00a5a7ad == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents___ctor__
		                );
		      DAT_ram_00a5a7ad = '\x01';
		    }
		    Unity_Services_Core_Internal_DependencyTree___ctor
		              (iVar5,param2,param4,param5,param6,
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents___ctor__
		              );
		    puVar7 = &
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents__Initialize__
		    ;
		  }
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___Dispose
		            (iVar5,*puVar7);
		  return iVar5;
		}
		*/

		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D94")]
		[Address(RVA = "0xB85A", Offset = "0xB85A", VA = "0xB85A", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Gameplay_Managers_Ad_Placements_AdPlacementData__ToString
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param2;
		  Core_Gameplay_Managers_Ad_Placements_AdPlacementData__Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_SetInfo
		            (param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D95")]
		[Address(RVA = "0xB85B", Offset = "0xB85B", VA = "0xB85B", Slot = "9")]
		private void SetInfo(AdPlacementInfo value)
		{
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D96")]
		[Address(RVA = "0xB85C", Offset = "0xB85C", VA = "0xB85C")]
		private void SetupTimer()
		{
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D97")]
		[Address(RVA = "0xB85D", Offset = "0xB85D", VA = "0xB85D")]
		private void OnTimerComplete()
		{
		/* --- GHIDRA: OnTimerComplete ---
		void Core_Gameplay_Managers_Ad_Placements_AdPlacementData__OnTimerComplete
		               (int param1,undefined4 param2)
		
		{
		  Utils_Timers_DelayedCall__DelayedCallAsync(*(undefined4 *)(param1 + 0x14),0);
		  *(undefined4 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D98")]
		[Address(RVA = "0xB85E", Offset = "0xB85E", VA = "0xB85E", Slot = "10")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_Ad_Placements_AdPlacementData__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a785 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents___ctor__
		              );
		    DAT_ram_00a5a785 = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_EnergyRegenAdPlacementModel__EnergyRegenAdPlacementController__EnergyRegenAdPlacementEvents___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04003965 RID: 14693
		[Token(Token = "0x4003965")]
		[FieldOffset(Offset = "0x10")]
		private BackTime _backTime;

		// Token: 0x04003966 RID: 14694
		[Token(Token = "0x4003966")]
		[FieldOffset(Offset = "0x14")]
		private DelayedCall _delayedCall;

		// Token: 0x04003967 RID: 14695
		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0x18")]
		private AdPlacementInfo _info;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Ad_Placements_AdPlacementData__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a780 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdPlacementData__TypeInfo);
		    DAT_ram_00a5a780 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAdPlacementData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdPlacementData__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: add_BackTimerCompleteEvent ---
		void Core_Gameplay_Managers_Ad_Placements_AdPlacementData__add_BackTimerCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a781 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAdPlacementData__TypeInfo);
		    DAT_ram_00a5a781 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAdPlacementData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAdPlacementData__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: remove_BackTimerCompleteEvent ---
		uint Core_Gameplay_Managers_Ad_Placements_AdPlacementData__remove_BackTimerCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x18) != 0) {
		    return (uint)(*(int *)(*(int *)(param1 + 0x18) + 0x10) != 0);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_IsAvailableByAppServer ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_AdPlacementData__get_IsAvailableByAppServer
		          (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param4;
		  undefined4 uVar1;
		  undefined4 param3;
		  float4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a783 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_18870);
		    DAT_ram_00a5a783 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 8);
		  param2_00 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = StringLiteral_18870;
		  param3 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(param1 + 0x10) == 0) {
		    local_8 = 0.0;
		  }
		  else {
		    local_8 = (float4)func_ii_7103(*(int *)(param1 + 0x10),0);
		  }
		  param4 = func_ii_1081(DAT_ram_00a6696c,&local_8);
		  uVar1 = func_ii_8529(uVar1,param2_00,param3,param4,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Core.Gameplay.Managers.Ad.Placements.IAdPlacementData.SetInfo ---
		void Core_Gameplay_Managers_Ad_Placements_AdPlacementData__Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_SetInfo
		               (int param1,undefined4 param2)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  longlong param1_01;
		  
		  if (DAT_ram_00a5a784 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a784 = '\x01';
		  }
		  Utils_Timers_DelayedCall__SetDelay(*(undefined4 *)(param1 + 0x14),0);
		  if ((*(int *)(param1 + 0x18) != 0) &&
		     (param1_01 = *(longlong *)(*(int *)(param1 + 0x18) + 0x18), param1_01 != 0)) {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(param1_01,0);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    *(undefined4 *)(param1 + 0x10) = param1_00;
		    Utils_Timers_DelayedCall__SetDelay(*(undefined4 *)(param1 + 0x14),param1_00,0);
		  }
		  return;
		}
		*/

}
