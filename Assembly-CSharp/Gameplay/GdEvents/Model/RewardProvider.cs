using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Main;

namespace Gameplay.GdEvents.Model
{
	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	public class RewardProvider : IRewardProvider
	{
		// Token: 0x06002CC3 RID: 11459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC3")]
		[Address(RVA = "0x7D4A", Offset = "0x7D4A", VA = "0x7D4A", Slot = "4")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_GdEvents_Model_RewardProvider__Clear
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a2d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__RewardInfo____set_Item__);
		    DAT_ram_00a5a2d8 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (*(undefined4 *)(param1 + 8),param2,param3,
		             Method_System_Collections_Generic_Dictionary_uint__RewardInfo____set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x7D4B", Offset = "0x7D4B", VA = "0x7D4B", Slot = "5")]
		public void SetReward(uint evtId, RewardInfo[] rewards)
		{
		/* --- GHIDRA: SetReward ---
		undefined4
		Gameplay_GdEvents_Model_RewardProvider__SetReward
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__RewardInfo____TryGetValue__);
		    DAT_ram_00a5a2da = '\x01';
		  }
		  uVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 8),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_uint__RewardInfo____TryGetValue__)
		  ;
		  return uVar1;
		}
		*/

		/* --- GHIDRA: SetReward ---
		undefined4
		Gameplay_GdEvents_Model_RewardProvider__SetReward
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__RewardInfo____TryGetValue__);
		    DAT_ram_00a5a2da = '\x01';
		  }
		  uVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 8),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_uint__RewardInfo____TryGetValue__)
		  ;
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x7D4C", Offset = "0x7D4C", VA = "0x7D4C", Slot = "6")]
		public void SetReward(uint evtId, ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards rewards)
		{
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x7D4D", Offset = "0x7D4D", VA = "0x7D4D", Slot = "7")]
		public bool TryGetReward(uint evtId, out RewardInfo[] rewards)
		{
		/* --- GHIDRA: TryGetReward ---
		uint Gameplay_GdEvents_Model_RewardProvider__TryGetReward
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 param1_01;
		  int iVar3;
		  undefined4 local_4;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5a2db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SingleOrDefault_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0__TryGetReward_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a5a2db = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param3;
		  uVar1 = 0;
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0xc),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___TryGetValue__
		                    );
		  param1_00 = local_4;
		  if (iVar2 != 0) {
		    param1_01 = unnamed_function_1417
		                          (
		                          System_Func_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__bool__TypeInfo
		                          );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_01,param2_00,
		               Method_Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0__TryGetReward_b__0__
		               ,0);
		    iVar3 = UI_SimpleIconValue__set_Value
		                      (param1_00,param1_01,
		                       Method_System_Linq_Enumerable_SingleOrDefault_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___
		                      );
		    uVar1 = (uint)(iVar3 != 0);
		  }
		  *param4 = iVar3;
		  return uVar1;
		}
		*/

		/* --- GHIDRA: TryGetReward ---
		uint Gameplay_GdEvents_Model_RewardProvider__TryGetReward
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 param1_01;
		  int iVar3;
		  undefined4 local_4;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5a2db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SingleOrDefault_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0__TryGetReward_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0_TypeInfo);
		    DAT_ram_00a5a2db = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param3;
		  uVar1 = 0;
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0xc),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___TryGetValue__
		                    );
		  param1_00 = local_4;
		  if (iVar2 != 0) {
		    param1_01 = unnamed_function_1417
		                          (
		                          System_Func_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards__bool__TypeInfo
		                          );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_01,param2_00,
		               Method_Gameplay_GdEvents_Model_RewardProvider___c__DisplayClass6_0__TryGetReward_b__0__
		               ,0);
		    iVar3 = UI_SimpleIconValue__set_Value
		                      (param1_00,param1_01,
		                       Method_System_Linq_Enumerable_SingleOrDefault_ProtoGetEventMilestonesRewardsInfoAns_Types_MilestoneRewards___
		                      );
		    uVar1 = (uint)(iVar3 != 0);
		  }
		  *param4 = iVar3;
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x7D4E", Offset = "0x7D4E", VA = "0x7D4E", Slot = "8")]
		public bool TryGetReward(uint evtId, uint milestoneNumber, out ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards rewards)
		{
			return default(bool);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x7D4F", Offset = "0x7D4F", VA = "0x7D4F")]
		public RewardProvider()
		{
		}

		// Token: 0x04001898 RID: 6296
		[Token(Token = "0x4001898")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<uint, RewardInfo[]> _eventRewards;

		// Token: 0x04001899 RID: 6297
		[Token(Token = "0x4001899")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<uint, List<ProtoGetEventMilestonesRewardsInfoAns.Types.MilestoneRewards>> _milestoneRewards;
	}
}
