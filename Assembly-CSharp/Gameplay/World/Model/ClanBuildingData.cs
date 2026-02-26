using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.World.Model
{
	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	public class ClanBuildingData : BaseBuildingData<ClanBuildingTypes>
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x17000326")]
		public override ClanBuildingTypes Type
		{
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x65C1", Offset = "0x65C1", VA = "0x65C1", Slot = "18")]
			get
			{
				return ClanBuildingTypes.UnknownClanBuildingType;
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x65C2", Offset = "0x65C2", VA = "0x65C2")]
		private ClanBuildingData(Dictionaries dictionaries)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_World_Model_ClanBuildingData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_ChatSmileDicExt__GetTitle(*(undefined4 *)(param1 + 0x40),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x1DEB", Offset = "0x1DEB", VA = "0x1DEB")]
		public static ClanBuildingData Create(BuildingInfo buildingInfo, uint cultId, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000327")]
		public override string Title
		{
			[Token(Token = "0x60013E5")]
			[Address(RVA = "0x65C3", Offset = "0x65C3", VA = "0x65C3", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000328")]
		public override string Description
		{
			[Token(Token = "0x60013E6")]
			[Address(RVA = "0x65C4", Offset = "0x65C4", VA = "0x65C4", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000329")]
		public override string UpgradeText
		{
			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x65C5", Offset = "0x65C5", VA = "0x65C5", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032A")]
		public override string IsleViewAssetId
		{
			[Token(Token = "0x60013E8")]
			[Address(RVA = "0x65C6", Offset = "0x65C6", VA = "0x65C6", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032B")]
		public override string IsleViewUiAssetId
		{
			[Token(Token = "0x60013E9")]
			[Address(RVA = "0x65C7", Offset = "0x65C7", VA = "0x65C7", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032C")]
		public override string MiniatureAssetId
		{
			[Token(Token = "0x60013EA")]
			[Address(RVA = "0x65C8", Offset = "0x65C8", VA = "0x65C8", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x1700032D")]
		public override ulong UpgradeTime
		{
			[Token(Token = "0x60013EB")]
			[Address(RVA = "0x65C9", Offset = "0x65C9", VA = "0x65C9", Slot = "11")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x1700032E")]
		public override bool IsMaxLevel
		{
			[Token(Token = "0x60013EC")]
			[Address(RVA = "0x65CA", Offset = "0x65CA", VA = "0x65CA", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032F")]
		public override RequirementDic UpgradeRequirements
		{
			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x65CB", Offset = "0x65CB", VA = "0x65CB", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x65CC", Offset = "0x65CC", VA = "0x65CC", Slot = "14")]
		public override Dictionary<string, string> GetReplacementsForLevel(uint level, Dictionaries dictionaries)
		{
		/* --- GHIDRA: GetReplacementsForLevel ---
		void Gameplay_World_Model_ClanBuildingData__GetReplacementsForLevel(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetGiftDic
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                     *(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),*(undefined4 *)(param1 + 0x2c),0
		                    );
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = Core_Extensions_Dict_DictExt__GetGiftDic
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                     *(int *)(*(int *)(param1 + 0xc) + 0x10) + 1,*(undefined4 *)(param1 + 0x2c),0);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  uVar1 = Core_Extensions_Dict_DictExt__GetPointPointsForMonsterDic
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                     *(undefined4 *)(*(int *)(param1 + 0xc) + 0x10),0);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = Core_Extensions_Dict_DictExt__GetPointPointsForMonsterDic
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),
		                     *(int *)(*(int *)(param1 + 0xc) + 0x10) + 1,0);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x65CD", Offset = "0x65CD", VA = "0x65CD", Slot = "17")]
		protected override void ValidateLevelDependentProperties()
		{
		/* --- GHIDRA: ValidateLevelDependentProperties ---
		undefined4
		Gameplay_World_Model_ClanBuildingData__ValidateLevelDependentProperties
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58c7a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3700);
		    DAT_ram_00a58c7a = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80f9314a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f9314a:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param2_00 = *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x18);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  iVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (iVar4,param2_00,param3,uVar3,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3700,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x18) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		            (uVar3,param2,param3,iVar4,0,0,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x65CE", Offset = "0x65CE", VA = "0x65CE", Slot = "16")]
		public override RequirementsInfoProvider GetUpgradeRequirementsProvider(UserData owner, UserData user)
		{
		/* --- GHIDRA: GetUpgradeRequirementsProvider ---
		int Gameplay_World_Model_ClanBuildingData__GetUpgradeRequirementsProvider
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  double *pdVar2;
		  double param2_00;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if ((*(int *)(iVar1 + 0x10) == 0) || (*(longlong *)(iVar1 + 0x18) == 0)) {
		    pdVar2 = (double *)(param1 + 0x18);
		  }
		  else {
		    pdVar2 = (double *)(iVar1 + 0x28);
		  }
		  if (*(int *)(param1 + 0x3c) == 0) {
		    return 0;
		  }
		  param2_00 = *pdVar2;
		  iVar1 = 0;
		  param1_00 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(*(int *)(param1 + 0x3c) + 0x14),0);
		  if (param1_00 != 0) {
		    param1_01 = Core_Extensions_Dict_ResourceSetExt__Round(param1_00,param2_00,0);
		    Core_Extensions_Dict_ResourceSetExt__SetValue(param1_01,0);
		    iVar1 = param1_00;
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000330")]
		public override ResourceSet BuildPrice
		{
			[Token(Token = "0x60013F1")]
			[Address(RVA = "0x65CF", Offset = "0x65CF", VA = "0x65CF", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x28")]
		private ClanBuildingTypes _type;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x2C")]
		private uint _cultId;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x30")]
		private ClanBuildingViewDic _currentBuildingLevelViewDic;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x34")]
		private ClanBuildingViewDic _nextBuildingLevelViewDic;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x38")]
		private ClanBuildingLevelDic _currentClanBuildingLevelDic;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x3C")]
		private ClanBuildingLevelDic _nextClanBuildingLevelDic;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x40")]
		private ClanBuildingTypeDic _clanBuildingTypeDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		void Gameplay_World_Model_ClanBuildingData__get_Type
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58c77 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Model_BaseBuildingData_ClanBuildingTypes___ctor__);
		    DAT_ram_00a58c77 = '\x01';
		  }
		  Cysharp_Threading_Tasks_Triggers_AsyncTriggerBase_AwakeMonitor___Il2CppFullySharedGenericType___MoveNext
		            (param1,param2,Method_Gameplay_World_Model_BaseBuildingData_ClanBuildingTypes___ctor__);
		  return;
		}
		*/


		/* --- GHIDRA: get_Title ---
		undefined4 Gameplay_World_Model_ClanBuildingData__get_Title(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_ClanBuildingTypeDicExt__GetTitle(*(undefined4 *)(param1 + 0x40),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Description ---
		undefined4 Gameplay_World_Model_ClanBuildingData__get_Description(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_ClanBuildingTypeDicExt__GetDescription
		                    (*(undefined4 *)(param1 + 0x40),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsleViewAssetId ---
		undefined4 Gameplay_World_Model_ClanBuildingData__get_IsleViewAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetMiniatureAssetId
		                    (*(undefined4 *)(param1 + 0x30),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsleViewUiAssetId ---
		undefined4
		Gameplay_World_Model_ClanBuildingData__get_IsleViewUiAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetAnimationAssetId
		                    (*(undefined4 *)(param1 + 0x30),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_UpgradeTime ---
		uint Gameplay_World_Model_ClanBuildingData__get_UpgradeTime(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 0x34) == 0);
		}
		*/


		/* --- GHIDRA: get_UpgradeRequirements ---
		undefined4
		Gameplay_World_Model_ClanBuildingData__get_UpgradeRequirements
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a58c79 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a58c79 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  func_ii_2946(param1_00,StringLiteral_25096,param3_00,
		               Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		  return param1_00;
		}
		*/

}
