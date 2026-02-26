using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Rating;
using UI.Tabs;

namespace Gameplay.VortexRating.Model
{
	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	public class VortexRatingModel : AbstractModel
	{
		// Token: 0x06001555 RID: 5461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001555")]
		[Address(RVA = "0x6717", Offset = "0x6717", VA = "0x6717")]
		public VortexRatingModel(UserData user)
		{
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000389")]
		public ProtoGetGreatTopAns GreatTop
		{
			[Token(Token = "0x6001556")]
			[Address(RVA = "0x6718", Offset = "0x6718", VA = "0x6718")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001557")]
			[Address(RVA = "0x6719", Offset = "0x6719", VA = "0x6719")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038A")]
		public Dictionary<ulong, GreatUserData> GreatUsers
		{
			[Token(Token = "0x6001558")]
			[Address(RVA = "0x671A", Offset = "0x671A", VA = "0x671A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001559")]
			[Address(RVA = "0x671B", Offset = "0x671B", VA = "0x671B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038B")]
		public RatingPrizeDic[] Prizes
		{
			[Token(Token = "0x600155A")]
			[Address(RVA = "0x671C", Offset = "0x671C", VA = "0x671C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600155B")]
			[Address(RVA = "0x671D", Offset = "0x671D", VA = "0x671D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x671E", Offset = "0x671E", VA = "0x671E")]
		public TabBarItemData[] GetTabBarItemData()
		{
		/* --- GHIDRA: GetTabBarItemData ---
		undefined4
		Gameplay_VortexRating_Model_VortexRatingModel__GetTabBarItemData(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a581cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a581cb = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x80eb547e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80eb547e:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
		  uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterKickCost
		                    (*(undefined4 *)(iVar4 + 0x28),*(undefined4 *)(param1 + 8),0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x671F", Offset = "0x671F", VA = "0x671F")]
		public ResourceSet GetPartyCombatCost()
		{
		/* --- GHIDRA: GetPartyCombatCost ---
		void Gameplay_VortexRating_Model_VortexRatingModel__GetPartyCombatCost
		               (int param1,int param2,undefined4 param3)
		
		{
		  *(int *)(param1 + 0x10) = param2;
		  Gameplay_VortexRating_Model_VortexRatingModel__PopulateGreatTop
		            (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155E")]
		[Address(RVA = "0x6720", Offset = "0x6720", VA = "0x6720")]
		public void PopulateGreatTop(ProtoGetGreatTopAns ans)
		{
		/* --- GHIDRA: PopulateGreatTop ---
		void Gameplay_VortexRating_Model_VortexRatingModel__PopulateGreatTop
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a581cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_GreatUserTopInfo__GreatUserData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_GreatUserData__ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatUserTopInfo__GreatUserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatUserData__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Model_VortexRatingModel___c__PopulateUsers_b__17_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Model_VortexRatingModel_ConstructGreatUserData__);
		    DAT_ram_00a581cc = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_GreatUserTopInfo__GreatUserData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_VortexRating_Model_VortexRatingModel_ConstructGreatUserData__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_GreatUserTopInfo__GreatUserData___);
		  if (*(int *)(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_GreatUserData__ulong__TypeInfo);
		    func_ii_7542(param1_00,param2_00,
		                 Method_Gameplay_VortexRating_Model_VortexRatingModel___c__PopulateUsers_b__17_0__,0
		                );
		    *(int *)(*(int *)(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__uint_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_ToDictionary_GreatUserData__ulong___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155F")]
		[Address(RVA = "0x6721", Offset = "0x6721", VA = "0x6721")]
		public void PopulateUsers(IList<GreatUserTopInfo> users)
		{
		/* --- GHIDRA: PopulateUsers ---
		int Gameplay_VortexRating_Model_VortexRatingModel__PopulateUsers
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a581cd == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Model_GreatUserData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a581cd = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_VortexRating_Model_GreatUserData_TypeInfo);
		  *(int *)(iVar1 + 8) = param2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(*(int *)(param2 + 0xc) + 0x1c),0)
		  ;
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  iVar3 = Core_Extensions_Dict_DictExt__GetDuelUserStateFlags
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0x18),0);
		  uVar2 = *(undefined4 *)(iVar3 + 0x1c);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar2,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  uVar2 = Google_Protobuf_Collections_RepeatedField_ulong___Clone
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x24),
		                     *(undefined8 *)(*(int *)(param2 + 0xc) + 0x10),
		                     Method_Google_Protobuf_Collections_RepeatedField_ulong__Contains__);
		  *(char *)(iVar1 + 0x14) = (char)uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001560")]
		[Address(RVA = "0x6722", Offset = "0x6722", VA = "0x6722")]
		private GreatUserData ConstructGreatUserData(GreatUserTopInfo greatUserInfo)
		{
		/* --- GHIDRA: ConstructGreatUserData ---
		void Gameplay_VortexRating_Model_VortexRatingModel__ConstructGreatUserData(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a581ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo);
		    DAT_ram_00a581ce = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_VortexRating_Model_VortexRatingModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Prizes ---
		int * Gameplay_VortexRating_Model_VortexRatingModel__set_Prizes(undefined4 param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a581ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17536);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17538);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17537);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17540);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17539);
		    DAT_ram_00a581ca = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,5);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17538,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 0;
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17540,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 1;
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[5] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17536,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x14) = 2;
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[6] = iVar2;
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17539,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 3;
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[7] = iVar2;
		    iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17537,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar2 + 0x14) = 4;
		    *(undefined4 *)(iVar2 + 0x10) = uVar3;
		    iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 != 0) {
		      piVar1[8] = iVar2;
		      return piVar1;
		    }
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = func_ii_1083();
		  func_ii_1050(uVar3,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
