using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Core.Dict;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Gameplay.WorldAxis.Model;
using Gameplay.WorldAxis.Office.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using UI.Tabs;

namespace Gameplay.WorldAxis.ColossusInfo.Model
{
	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2000329")]
	public class ColossusInfoModel : AbstractModel
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6001290")]
			[Address(RVA = "0x648A", Offset = "0x648A", VA = "0x648A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001291")]
			[Address(RVA = "0x648B", Offset = "0x648B", VA = "0x648B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		public WorldAxisOfficeModel.ColossusClanRating[] Rating
		{
			[Token(Token = "0x6001292")]
			[Address(RVA = "0x648C", Offset = "0x648C", VA = "0x648C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001293")]
			[Address(RVA = "0x648D", Offset = "0x648D", VA = "0x648D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		public ColossusCombatRewards CombatRewards
		{
			[Token(Token = "0x6001294")]
			[Address(RVA = "0x648E", Offset = "0x648E", VA = "0x648E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001295")]
			[Address(RVA = "0x648F", Offset = "0x648F", VA = "0x648F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x170002E3")]
		public bool IsMyColossus
		{
			[Token(Token = "0x6001296")]
			[Address(RVA = "0x6490", Offset = "0x6490", VA = "0x6490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x6491", Offset = "0x6491", VA = "0x6491")]
		public ColossusInfoModel(UserData user, ColossusBattleData colossusBattleData, WorldAxisModel worldAxisModel)
		{
		/* --- GHIDRA: <SetRatings>b__19_0 ---
		void Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___SetRatings_b__19_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58bdf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo);
		    DAT_ram_00a58bdf = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a58bdc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17787);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17780);
		    DAT_ram_00a58bdc = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17780,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x14) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  iVar3 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17779,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 0x14) = 1;
		  *(undefined4 *)(iVar3 + 0x10) = uVar2;
		  iVar1 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17787,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 0x14) = 2;
		  *(undefined4 *)(iVar3 + 0x10) = uVar2;
		  iVar1 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar3;
		    return param1_00;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x6492", Offset = "0x6492", VA = "0x6492")]
		public List<TabBarItemData> GetTabBarItemData()
		{
		/* --- GHIDRA: GetTabBarItemData ---
		void Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__GetTabBarItemData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58bdd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__SetRatings_b__19_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderByDescending_WorldAxisOfficeModel_ColossusClanRating__long___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ColossusRating__WorldAxisOfficeModel_ColossusClanRating___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_WorldAxisOfficeModel_ColossusClanRating___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_WorldAxisOfficeModel_ColossusClanRating__long__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ColossusRating__WorldAxisOfficeModel_ColossusClanRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c__SetRatings_b__19_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo);
		    DAT_ram_00a58bdd = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Func_ColossusRating__WorldAxisOfficeModel_ColossusClanRating__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__SetRatings_b__19_0__,0)
		  ;
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ColossusRating__WorldAxisOfficeModel_ColossusClanRating___
		                    );
		  if (*(int *)(Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417
		                          (System_Func_WorldAxisOfficeModel_ColossusClanRating__long__TypeInfo);
		    System_Func_object__Int32Enum___Invoke
		              (param1_00,param2_00,
		               Method_Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c__SetRatings_b__19_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___c_TypeInfo + 0x5c) +
		            4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__OrderByDescending_KeyValuePair_object__object___uint_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_OrderByDescending_WorldAxisOfficeModel_ColossusClanRating__long___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_WorldAxisOfficeModel_ColossusClanRating___
		                      );
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x6493", Offset = "0x6493", VA = "0x6493")]
		public void SetRatings(IList<ColossusRating> ratings)
		{
		/* --- GHIDRA: SetRatings ---
		undefined4
		Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__SetRatings
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58bde == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_ColossusClanRating_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58bde = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80f865be;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f865be:
		  param3_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_ColossusClanRating_TypeInfo
		                        );
		  Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___AddRating_b__12_0
		            (param1_00,param2,param3_00,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x14")]
		public readonly IBalanceSource Treasury;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x18")]
		public readonly ColossusBattleData ColossusBattleData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CombatRewards ---
		uint Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__set_CombatRewards
		               (int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  int iVar2;
		  longlong lVar3;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x18) + 0x14);
		  if (iVar2 != 0) {
		    lVar3 = *(longlong *)(*(int *)(iVar2 + 0x1c) + 0x10);
		    lVar1 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		    return (uint)(lVar3 == lVar1);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_IsMyColossus ---
		void Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__get_IsMyColossus
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58bdb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58bdb = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80f848d8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f848d8:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x18);
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0x14) = uVar5;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f84998;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f84998:
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0xc) = uVar5;
		  param1_00 = unnamed_function_1417
		                        (Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards_TypeInfo);
		  Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards__get_CombatWinReward
		            (param1_00,uVar5,uVar5);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  return;
		}
		*/

}
