using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.World.Model
{
	// Token: 0x0200036B RID: 875
	[Token(Token = "0x200036B")]
	public class UserBuildingData : BaseBuildingData<UserBuildingTypes>
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x17000345")]
		public override UserBuildingTypes Type
		{
			[Token(Token = "0x600143B")]
			[Address(RVA = "0x660A", Offset = "0x660A", VA = "0x660A", Slot = "18")]
			get
			{
				return UserBuildingTypes.UnknownUserBuildingType;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000346")]
		public override string Title
		{
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x660B", Offset = "0x660B", VA = "0x660B", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000347")]
		public override string Description
		{
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x660C", Offset = "0x660C", VA = "0x660C", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000348")]
		public override string UpgradeText
		{
			[Token(Token = "0x600143E")]
			[Address(RVA = "0x660D", Offset = "0x660D", VA = "0x660D", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000349")]
		public override string IsleViewAssetId
		{
			[Token(Token = "0x600143F")]
			[Address(RVA = "0x660E", Offset = "0x660E", VA = "0x660E", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034A")]
		public override string IsleViewUiAssetId
		{
			[Token(Token = "0x6001440")]
			[Address(RVA = "0x660F", Offset = "0x660F", VA = "0x660F", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034B")]
		public override string MiniatureAssetId
		{
			[Token(Token = "0x6001441")]
			[Address(RVA = "0x6610", Offset = "0x6610", VA = "0x6610", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x1700034C")]
		public override ulong UpgradeTime
		{
			[Token(Token = "0x6001442")]
			[Address(RVA = "0x6611", Offset = "0x6611", VA = "0x6611", Slot = "11")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x1700034D")]
		public override bool IsMaxLevel
		{
			[Token(Token = "0x6001443")]
			[Address(RVA = "0x6612", Offset = "0x6612", VA = "0x6612", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034E")]
		public override RequirementDic UpgradeRequirements
		{
			[Token(Token = "0x6001444")]
			[Address(RVA = "0x6613", Offset = "0x6613", VA = "0x6613", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x6614", Offset = "0x6614", VA = "0x6614")]
		private UserBuildingData(Dictionaries dictionaries)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_UserBuildingData___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetUserBuildingTypeDic(param1[2],param1[4],0);
		  param1[0xd] = iVar1;
		  iVar1 = param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x154));
		  iVar1 = Core_Extensions_Dict_DictExt__GetUserBuildingViewsDic
		                    (iVar1,uVar2,*(undefined4 *)(param1[3] + 0x10),0);
		  param1[0xe] = iVar1;
		  iVar1 = param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x154));
		  iVar1 = Core_Extensions_Dict_DictExt__GetUserBuildingViewsDic
		                    (iVar1,uVar2,*(int *)(param1[3] + 0x10) + 1,0);
		  param1[0xf] = iVar1;
		  if (iVar1 != 0) {
		    iVar1 = Core_Extensions_Dict_DictExt__GetStringParameter
		                      (param1[2],*(undefined4 *)(iVar1 + 0x14),0);
		    param1[0x10] = iVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x6615", Offset = "0x6615", VA = "0x6615", Slot = "17")]
		protected override void ValidateLevelDependentProperties()
		{
		/* --- GHIDRA: ValidateLevelDependentProperties ---
		int Gameplay_World_Model_UserBuildingData__ValidateLevelDependentProperties
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
		  if (*(int *)(param1 + 0x40) == 0) {
		    return 0;
		  }
		  param2_00 = *pdVar2;
		  iVar1 = 0;
		  param1_00 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(*(int *)(param1 + 0x40) + 0x10),0);
		  if (param1_00 != 0) {
		    param1_01 = Core_Extensions_Dict_ResourceSetExt__Round(param1_00,param2_00,0);
		    Core_Extensions_Dict_ResourceSetExt__SetValue(param1_01,0);
		    iVar1 = param1_00;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034F")]
		public override ResourceSet BuildPrice
		{
			[Token(Token = "0x6001447")]
			[Address(RVA = "0x6616", Offset = "0x6616", VA = "0x6616", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x1E04", Offset = "0x1E04", VA = "0x1E04")]
		public static UserBuildingData Create(UserBuildingInfo buildingInfo, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x6617", Offset = "0x6617", VA = "0x6617", Slot = "14")]
		public override Dictionary<string, string> GetReplacementsForLevel(uint level, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x28")]
		private UserBuildingTypes _type;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x2C")]
		private UserBuildingInfo _userBuildingInfo;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x30")]
		private UserBuildingTypeDic _userBuildingTypeDic;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x34")]
		private UserBuildingViewsDic _userBuildingViewsDic;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x38")]
		private UserBuildingLevelDic _currentUserBuildingLevelDic;

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x3C")]
		private UserBuildingLevelDic _nextBuildingLevelDic;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x40")]
		private RequirementDic _upgradeRequirements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		undefined4 Gameplay_World_Model_UserBuildingData__get_Type(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_TutorialUIPointerDicExt__GetView(*(undefined4 *)(param1 + 0x30),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Title ---
		undefined4 Gameplay_World_Model_UserBuildingData__get_Title(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_UserBuildingTypeDicExt__GetTitle(*(undefined4 *)(param1 + 0x30),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Description ---
		undefined4 Gameplay_World_Model_UserBuildingData__get_Description(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_UserBuildingTypeDicExt__GetDescription
		                    (*(undefined4 *)(param1 + 0x30),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_UpgradeText ---
		undefined4 Gameplay_World_Model_UserBuildingData__get_UpgradeText(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_UserBuildingViewsDicExt__GetAnimationUiAssetId
		                    (*(undefined4 *)(param1 + 0x34),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsleViewAssetId ---
		undefined4 Gameplay_World_Model_UserBuildingData__get_IsleViewAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_UserBuildingViewsDicExt__GetIsleViewAssetId
		                    (*(undefined4 *)(param1 + 0x34),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsleViewUiAssetId ---
		undefined4
		Gameplay_World_Model_UserBuildingData__get_IsleViewUiAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_UserBuildingViewsDicExt__GetImageAssetId
		                    (*(undefined4 *)(param1 + 0x34),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_MiniatureAssetId ---
		undefined8 Gameplay_World_Model_UserBuildingData__get_MiniatureAssetId(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 0x3c) + 0x18);
		}
		*/


		/* --- GHIDRA: get_UpgradeTime ---
		uint Gameplay_World_Model_UserBuildingData__get_UpgradeTime(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 0x3c) == 0);
		}
		*/


		/* --- GHIDRA: get_UpgradeRequirements ---
		void Gameplay_World_Model_UserBuildingData__get_UpgradeRequirements
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58c88 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Model_BaseBuildingData_UserBuildingTypes___ctor__);
		    DAT_ram_00a58c88 = '\x01';
		  }
		  Cysharp_Threading_Tasks_Triggers_AsyncTriggerBase_AwakeMonitor___Il2CppFullySharedGenericType___MoveNext
		            (param1,param2,Method_Gameplay_World_Model_BaseBuildingData_UserBuildingTypes___ctor__);
		  return;
		}
		*/


		/* --- GHIDRA: get_BuildPrice ---
		undefined4
		Gameplay_World_Model_UserBuildingData__get_BuildPrice
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  double param1_01;
		  float4 local_10;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a58c8a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27166);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22947);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28645);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27810);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24883);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a58c8a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  func_ii_2946(param1_00,StringLiteral_25096,uVar1,
		               Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))
		                    (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x154));
		  if (iVar2 == 1) {
		    iVar2 = Core_Extensions_Dict_DictExt__GetMedalRank(param3,local_4,0);
		    if (iVar2 == 0) {
		      param1_01 = 0.0;
		    }
		    else {
		      _local_10 = 0;
		      System_Data_SqlTypes_SqlInt32___ctor
		                (&local_10,*(undefined4 *)(iVar2 + 0x10),Method_System_Nullable_uint___ctor__);
		      param1_01 = (double)(_local_10 >> 0x20);
		    }
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar1 = UI_SimpleIconValue__set_IconAssetId(param1_01,StringLiteral_28780,0);
		    func_ii_2946(param1_00,StringLiteral_22947,uVar1,
		                 Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x154));
		    if (iVar2 == 2) {
		      iVar2 = Core_Extensions_Dict_DictExt__GetTreeLevelDic(param3,local_4,0);
		      _local_10 = CONCAT44(local_10,*(float *)(iVar2 + 0x10) * 100.0);
		      uVar1 = func_ii_1081(DAT_ram_00a6696c,&local_10);
		      uVar1 = func_ii_4419(StringLiteral_28645,uVar1,0);
		      func_ii_2946(param1_00,StringLiteral_27810,uVar1,
		                   Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x154));
		      if (iVar2 == 3) {
		        iVar2 = Core_Extensions_Dict_DictExt__GetArenaLevelDic(param3,local_4,0);
		        _local_10 = CONCAT44(local_10,*(undefined4 *)(iVar2 + 0x10));
		        uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_10,0);
		        func_ii_2946(param1_00,StringLiteral_24883,uVar1,
		                     Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		        _local_10 = CONCAT44(local_10,*(undefined4 *)(iVar2 + 0x14));
		        uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_10,0);
		        func_ii_2946(param1_00,StringLiteral_27166,uVar1,
		                     Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		      }
		    }
		  }
		  return param1_00;
		}
		*/

}
