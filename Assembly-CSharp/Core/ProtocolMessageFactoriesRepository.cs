using System;
using System.Collections.Generic;
using Core.Net.Connection;
using Core.Net.Factories;
using Google.Protobuf;
using Il2CppDummyDll;

namespace Core
{
	// Token: 0x02000E5F RID: 3679
	[Token(Token = "0x2000E5F")]
	public class ProtocolMessageFactoriesRepository : IProtocolMessageFactoriesRepository
	{
		// Token: 0x060059FA RID: 23034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059FA")]
		[Address(RVA = "0xA70D", Offset = "0xA70D", VA = "0xA70D")]
		private string GetKey(int serviceId, uint eventId)
		{
		/* --- GHIDRA: GetKey ---
		void Core_ProtocolMessageFactoriesRepository__GetKey
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60555 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__IProtocolMessageFactory__Add__)
		    ;
		    DAT_ram_00a60555 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 8);
		  local_8 = param3;
		  local_4 = param2;
		  if (DAT_ram_00a60554 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a60554 = '\x01';
		  }
		  uVar1 = func_ii_4443(&local_4,0);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_19176,param3_00,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,param4,
		             Method_System_Collections_Generic_Dictionary_string__IProtocolMessageFactory__Add__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FB")]
		public void Add<T>(int serviceId, uint id) where T : IMessage, new()
		{
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FC")]
		[Address(RVA = "0xA70E", Offset = "0xA70E", VA = "0xA70E")]
		public void Add(int serviceId, uint id, IProtocolMessageFactory factory)
		{
		/* --- GHIDRA: Add ---
		undefined4
		Core_ProtocolMessageFactoriesRepository__Add
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60556 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__IProtocolMessageFactory__TryGetValue__
		              );
		    DAT_ram_00a60556 = '\x01';
		  }
		  local_8 = param3;
		  local_4 = param2;
		  if (DAT_ram_00a60554 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a60554 = '\x01';
		  }
		  uVar1 = func_ii_4443(&local_4,0);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_19176,param3_00,0);
		  uVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 8),uVar1,param4,
		                     Method_System_Collections_Generic_Dictionary_string__IProtocolMessageFactory__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

		/* --- GHIDRA: Add<__Il2CppFullySharedGenericType> ---
		int Core_ProtocolMessageFactoriesRepository__Add___Il2CppFullySharedGenericType_
		              (int param1,int param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param2_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (*(int *)(param2 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__IStoreConfiguration__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__IStoreConfiguration__get_Item__);
		    if (*(int *)(param2 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param2);
		    }
		  }
		  uVar2 = UnityEngine_Purchasing_PurchasingFactory__set_storeName(param1,0);
		  iVar4 = **(int **)(param2 + 0x1c);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  iVar4 = func_ii_1082(uVar2,iVar4);
		  if (iVar4 == 0) {
		    uVar2 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 4);
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    param2_00 = (int *)func_ii_2734(uVar2,0);
		    iVar4 = System_Xml_Schema_SchemaInfo__get_Notations
		                      (*(undefined4 *)(param1 + 8),param2_00,
		                       Method_System_Collections_Generic_Dictionary_Type__IStoreConfiguration__ContainsKey__
		                      );
		    if (iVar4 == 0) {
		      uVar2 = unnamed_function_2232(&StringLiteral_11506);
		      if (param2_00 == (int *)0x0) {
		        uVar5 = 0;
		      }
		      else {
		        uVar5 = (**(code **)((ulonglong)*(uint *)(*param2_00 + 0xd8) * 4))
		                          (param2_00,*(undefined4 *)(*param2_00 + 0xdc));
		      }
		      uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,uVar5,0);
		      uVar5 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		      uVar5 = unnamed_function_1417(uVar5);
		      func_ii_3067(uVar5,uVar2,0);
		      func_ii_1050(uVar5,param2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = 0;
		    iVar3 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(param1 + 8),param2_00,
		                       Method_System_Collections_Generic_Dictionary_Type__IStoreConfiguration__get_Item__
		                      );
		    iVar4 = **(int **)(param2 + 0x1c);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,iVar4), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar3,iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    iVar1 = 0;
		    iVar3 = UnityEngine_Purchasing_PurchasingFactory__set_storeName(param1,0);
		    iVar4 = **(int **)(param2 + 0x1c);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,iVar4), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar3,iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Add<object> ---
		void Core_ProtocolMessageFactoriesRepository__Add_object_
		               (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 param4_00;
		  int *piVar1;
		  int param1_00;
		  uint *puVar2;
		  
		  piVar1 = *(int **)(param4 + 0x1c);
		  if (piVar1 == (int *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		    piVar1 = *(int **)(param4 + 0x1c);
		  }
		  param1_00 = *piVar1;
		  if ((*(byte *)(param1_00 + 0xbd) & 1) == 0) {
		    param1_00 = func_ii_1079(param1_00);
		  }
		  param4_00 = unnamed_function_1417(param1_00);
		  puVar2 = *(uint **)(*(int *)(param4 + 0x1c) + 4);
		  (**(code **)((ulonglong)*puVar2 * 4))(param4_00,(int)(short)param2,(int)(short)param3,puVar2);
		  Core_ProtocolMessageFactoriesRepository__GetKey(param1,param2,param3,param4_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060059FD RID: 23037 RVA: 0x0000FF30 File Offset: 0x0000E130
		[Token(Token = "0x60059FD")]
		[Address(RVA = "0xA70F", Offset = "0xA70F", VA = "0xA70F", Slot = "4")]
		public bool TryGetFactory(int serviceId, uint id, out IProtocolMessageFactory factory)
		{
		/* --- GHIDRA: TryGetFactory ---
		void Core_ProtocolMessageFactoriesRepository__TryGetFactory(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60557 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__IProtocolMessageFactory___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__IProtocolMessageFactory__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_ProtocolMessageFactoriesRepository_Add_AccountInfo___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ActiveTeamArchivedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_AdTransactionClosedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetListCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ChatUserInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_CreateRequestEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_DuelStateInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_InstanceInfoEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_InstanceState___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_MercenaryInvitesEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_MercenaryTeamsEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_MinionAttackEvt___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_MinionAttackServerCancelationEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_MonsterHealthEvt___);
		    Mono_Security_ASN1__get_Item(&Method_Core_ProtocolMessageFactoriesRepository_Add_MoveUserEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAdditionalRewardChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAdmonitionEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAnimationStartedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAntiqEffectTriggeredEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoArtifactBuyedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoArtifactMovedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAttackabilityChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAuchanButtonBacklightEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBalanceChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBanStatusChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBetChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBetChangedOnPlayerEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingAcceleratedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingAcceleratedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingCanceledEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingCanceledEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingFinishedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingFinishedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingStartedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingStartedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoChatEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoChatMessageEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanLeaderChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanRemovedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanRestrictionChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanWarCompleteEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatBankChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatCompleteEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatCompleteEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatEventsEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatTerminatedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCompetitionRatingChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCompetitionStateChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoComplaintProcessedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoContactRemovedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCraftSlotsChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCurrentTnmCombatCompleteEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDailyQuestsChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDefaultUserCmd___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDictionariesUpdatedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDuelPaidOffEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDuelUserStateChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoEffectsChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoEmptyEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoEnergyChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoExperienceChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFieldChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFieldChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFighterCountChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFinalTnmCombatCompleteEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFrescoUniversalFragmentsChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFrescoUpdatedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetCaveInfoAns___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetColossusInfoAns___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetEventsListAns___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetPartyInfoAns___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetScheduleAns___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGoHomeEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGolemStateChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGreatRatingSetChangedEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGreatRatingTopChangedEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoHealtChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoHealthChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoInventoryChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoIsleMonsterFlewAwayEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoIsleMonsterInfoChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoJoinRoomEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoJumpToCombatEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellAcceleratedEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellAcceleratedEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellCanceledEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellCanceledEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellFinishedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellFinishedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellStartedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellStartedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoManufactureGetInfoAns___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoMarketArtifactsAddedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoMarketArtifactsRemovedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoMarketOptionsDisabledEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewComplaintEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewLevelEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewMedalsEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewWarDeclaredEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPaymentRewardsChangedEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPlayerActionEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPlayerAddedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPlayersCountChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalDoneEvt___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalMonsterInfoChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalStageInfoChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalStartedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalUserBetChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalUserInfoChangedEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRegenTreeEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRemoveMessageEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRequestCanceledEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoResourcesChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRewardChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRightsChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSeasonFinishedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSeasonStartedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoShowHintEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSkillsChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSkillsChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSkillsChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSlotsChanged___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellActionExpiredEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellAppliedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellCoolDownChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellUsedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoStateChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoStateChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSwitchTurnEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTakeOffMedalsEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoThemeDuelStateChangedEvt___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoThemeScoreChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTotalRatingChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTreasuryChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTriggersChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUnjoinRoomEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserAprChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserEntryAttempsChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserInfoChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserIsleBuildingViewChangedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserIsleDecorationAddedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserIsleDecorationRemovedEvt___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserLeftClanEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserScoreChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoWarModeChangedEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoWarStateChangedEvt___);
		    Mono_Security_ASN1__get_Item(&Method_Core_ProtocolMessageFactoriesRepository_Add_RefPayEvt___);
		    Mono_Security_ASN1__get_Item(&Method_Core_ProtocolMessageFactoriesRepository_Add_TeamInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_TeamTimeoutEvt___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_ProtocolMessageFactoriesRepository_Add_UserProfession___);
		    Mono_Security_ASN1__get_Item(&Method_Core_ProtocolMessageFactoriesRepository_Add_UserScheme___);
		    DAT_ram_00a60557 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_string__IProtocolMessageFactory__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_string__IProtocolMessageFactory___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  Core_ProtocolMessageFactoriesRepository__GetKey(param1,0,1,0,param1);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,1,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBanStatusChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2a,2,Method_Core_ProtocolMessageFactoriesRepository_Add_MoveUserEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,0xf,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTriggersChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,0x12,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewLevelEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,0x11,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoExperienceChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDictionariesUpdatedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,0x10,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoInventoryChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,0x13,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewMedalsEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,0x14,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTakeOffMedalsEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,2,0x17,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSkillsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2d,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserScoreChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2d,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserEntryAttempsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2d,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoThemeDuelStateChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2e,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalStartedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2e,2,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalDoneEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2e,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalStageInfoChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2e,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalUserBetChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2e,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalUserInfoChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2e,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPortalMonsterInfoChangedEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,1,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoJumpToCombatEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,2,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPlayerActionEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,3,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSwitchTurnEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,4,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFieldChangedEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,5,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSkillsChangedEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,6,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatEventsEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,7,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoChatEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,8,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoShowHintEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,9,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellCoolDownChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,10,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoEffectsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0xb,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellAppliedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0xc,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatBankChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0xd,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPlayerAddedEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0xe,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDefaultUserCmd___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0x11,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatCompleteEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0x12,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatTerminatedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0xf,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoThemeScoreChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,10,0x13,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAntiqEffectTriggeredEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1b,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoEnergyChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1b,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBalanceChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1b,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoResourcesChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xc,4,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoStateChangedEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xc,1,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBetChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xc,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBetChangedOnPlayerEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xc,3,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoHealtChangedEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xc,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCurrentTnmCombatCompleteEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xc,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFinalTnmCombatCompleteEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x15,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoStateChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x15,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCurrentTnmCombatCompleteEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x15,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFinalTnmCombatCompleteEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x15,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoHealthChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x15,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRequestCanceledEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x15,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFighterCountChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingAcceleratedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingFinishedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingCanceledEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingStartedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,5,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGoHomeEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,6,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserAprChangedEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,7,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAnimationStartedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,8,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoIsleMonsterInfoChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,9,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserIsleBuildingViewChangedEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,10,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserIsleDecorationAddedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,0xb,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserIsleDecorationRemovedEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,3,0xc,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoIsleMonsterFlewAwayEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,7,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellAcceleratedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,7,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellFinishedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,7,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellCanceledEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,7,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellStartedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,8,1,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetCaveInfoAns___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,4,1,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRegenTreeEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xd,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTotalRatingChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xd,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGreatRatingTopChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xd,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGreatRatingSetChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xd,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCompetitionRatingChangedEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x14,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetEventsListAns___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,5,1,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoArtifactBuyedEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,5,2,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoArtifactMovedEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,5,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoMarketArtifactsAddedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,5,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoMarketArtifactsRemovedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,5,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoMarketOptionsDisabledEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,1,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoJoinRoomEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,2,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUnjoinRoomEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,3,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoChatMessageEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserInfoChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewComplaintEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoComplaintProcessedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,8,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAdmonitionEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,9,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRemoveMessageEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,0xb,Method_Core_ProtocolMessageFactoriesRepository_Add_ChatUserInfo___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,0xc,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoContactRemovedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,0xd,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRightsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x13,0xe,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAttackabilityChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,8,Method_Core_ProtocolMessageFactoriesRepository_Add_InstanceInfoEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ActiveTeamArchivedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,7,Method_Core_ProtocolMessageFactoriesRepository_Add_TeamTimeoutEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,9,Method_Core_ProtocolMessageFactoriesRepository_Add_CreateRequestEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,2,Method_Core_ProtocolMessageFactoriesRepository_Add_TeamInfo___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,3,Method_Core_ProtocolMessageFactoriesRepository_Add_MonsterHealthEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,1,Method_Core_ProtocolMessageFactoriesRepository_Add_InstanceState___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,5,Method_Core_ProtocolMessageFactoriesRepository_Add_MercenaryInvitesEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,4,Method_Core_ProtocolMessageFactoriesRepository_Add_MercenaryTeamsEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,10,Method_Core_ProtocolMessageFactoriesRepository_Add_MinionAttackEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1e,0xb,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_MinionAttackServerCancelationEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x18,1,Method_Core_ProtocolMessageFactoriesRepository_Add_UserProfession___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x18,2,Method_Core_ProtocolMessageFactoriesRepository_Add_UserScheme___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x18,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCraftSlotsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x18,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoManufactureGetInfoAns___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xb,1,Method_Core_ProtocolMessageFactoriesRepository_Add_AccountInfo___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xb,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAuchanButtonBacklightEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xb,2,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoEmptyEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xb,5,Method_Core_ProtocolMessageFactoriesRepository_Add_RefPayEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xb,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_AdTransactionClosedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xb,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPaymentRewardsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1a,1,Method_Core_ProtocolMessageFactoriesRepository_Add_DuelStateInfo___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1a,2,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDuelPaidOffEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1a,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDuelUserStateChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xe,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoStackableChangesAns___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xe,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoTreasuryChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xe,3,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoUserLeftClanEvt___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xe,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanLeaderChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xe,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanRestrictionChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x11,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoNewWarDeclaredEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x11,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoWarStateChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x11,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPlayersCountChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x11,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanWarCompleteEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x11,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSeasonStartedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x11,7,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSeasonFinishedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x11,8,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoWarModeChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSkillsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFieldChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,0x11,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatCompleteEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoJumpToCombatEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoPlayerActionEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,3,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSwitchTurnEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatEventsEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,8,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoShowHintEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,9,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellCoolDownChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,10,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoEffectsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,0xb,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellAppliedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x20,0x12,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCombatTerminatedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xf,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingAcceleratedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xf,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingFinishedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xf,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingStartedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xf,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoBuildingCanceledEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xf,5,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGolemStateChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0xf,6,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoClanRemovedEvt___)
		  ;
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x10,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellAcceleratedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x10,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellFinishedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x10,3,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellCanceledEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x10,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoLearnSpellStartedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x10,5,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellUsedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x10,6,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSpellActionExpiredEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x12,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoAdditionalRewardChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x12,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoRewardChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x21,1,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoSlotsChanged___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x21,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetColossusInfoAns___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x21,3,Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetScheduleAns___
		            );
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x21,4,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetPartyInfoAns___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x2f,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoGetListCmd_Types_Ans___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x30,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoCompetitionStateChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x1f,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoDailyQuestsChangedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x31,1,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFrescoUpdatedEvt___);
		  Google_Protobuf_Collections_ProtobufEqualityComparers__GetEqualityComparer___Il2CppFullySharedGenericType_
		            (param1,0x31,2,
		             Method_Core_ProtocolMessageFactoriesRepository_Add_ProtoFrescoUniversalFragmentsChangedEvt___
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059FE")]
		[Address(RVA = "0xA710", Offset = "0xA710", VA = "0xA710")]
		public ProtocolMessageFactoriesRepository()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_ProtocolMessageFactoriesRepository___ctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a60558 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3166);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3168);
		    DAT_ram_00a60558 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  return StringLiteral_3166;
		}
		*/

		}

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, IProtocolMessageFactory> Factories;
	}
}
