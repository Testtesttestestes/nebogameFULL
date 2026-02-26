using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005CE RID: 1486
	[Token(Token = "0x20005CE")]
	public class PortalMonsterData
	{
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A1")]
		public MonsterDic MonsterDic
		{
			[Token(Token = "0x6002392")]
			[Address(RVA = "0x74E4", Offset = "0x74E4", VA = "0x74E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002393")]
			[Address(RVA = "0x74E5", Offset = "0x74E5", VA = "0x74E5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A2")]
		public AprDicWrapper Apr
		{
			[Token(Token = "0x6002394")]
			[Address(RVA = "0x74E6", Offset = "0x74E6", VA = "0x74E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002395")]
			[Address(RVA = "0x74E7", Offset = "0x74E7", VA = "0x74E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A3")]
		public PortalMonsterInfo MonsterInfo
		{
			[Token(Token = "0x6002396")]
			[Address(RVA = "0x74E8", Offset = "0x74E8", VA = "0x74E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002397")]
			[Address(RVA = "0x74E9", Offset = "0x74E9", VA = "0x74E9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x00006E58 File Offset: 0x00005058
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A4")]
		public uint DropChance
		{
			[Token(Token = "0x6002398")]
			[Address(RVA = "0x74EA", Offset = "0x74EA", VA = "0x74EA")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002399")]
			[Address(RVA = "0x74EB", Offset = "0x74EB", VA = "0x74EB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x74EC", Offset = "0x74EC", VA = "0x74EC")]
		public static PortalMonsterData Create(PortalMonsterInfo monsterInfo, IDictProvider dictionaries, uint dropChance)
		{
		/* --- GHIDRA: Create ---
		undefined4
		Gameplay_Portals_Model_PortalMonsterData__Create
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5811e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5811e = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_RewardData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_RewardData___ctor__);
		  iVar1 = Gameplay_Portals_Model_PortalMonsterData__TryGetPortalCurrencyRewards
		                    (param1,param2,param1_00,&local_4,param1_00);
		  uVar2 = local_4;
		  if (iVar1 != 0) {
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(uVar2,0);
		    iVar1 = Method_System_Collections_Generic_List_RewardData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Gameplay_Portals_Model_PortalMonsterData__TryGetExpRewards
		                    (param1,param2,param3,&local_8,param1_00);
		  uVar2 = local_8;
		  if (iVar1 != 0) {
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(uVar2,0);
		    iVar1 = Method_System_Collections_Generic_List_RewardData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  if (DAT_ram_00a5811f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a5811f = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(iVar1,0);
		  *(undefined4 *)(iVar1 + 0xc) = 0x20;
		  func_ii_7707(*(undefined4 *)(iVar1 + 0x10),*(undefined4 *)(param1 + 0x14),
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(iVar1,0);
		  iVar1 = Method_System_Collections_Generic_List_RewardData__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (param1_00,Method_System_Collections_Generic_List_RewardData__ToArray__);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x74ED", Offset = "0x74ED", VA = "0x74ED")]
		public RewardData[] GetRewards(UserData user, Dictionaries dictionaries)
		{
		/* --- GHIDRA: GetRewards ---
		undefined4
		Gameplay_Portals_Model_PortalMonsterData__GetRewards
		          (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5811f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a5811f = '\x01';
		  }
		  *param4 = 0;
		  param1_00 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = 0x20;
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),*(undefined4 *)(param1 + 0x14),
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  *param4 = param1_00;
		  return 1;
		}
		*/

			return null;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x74EE", Offset = "0x74EE", VA = "0x74EE")]
		private bool TryGetPortalCurrencyRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
		/* --- GHIDRA: TryGetPortalCurrencyRewards ---
		undefined4
		Gameplay_Portals_Model_PortalMonsterData__TryGetPortalCurrencyRewards
		          (int param1,int param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  int param1_00;
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a58120 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a58120 = '\x01';
		  }
		  *param4 = 0;
		  if (*(char *)(param2 + 0x74) == '\0') {
		    if (*(int *)(*(int *)(param1 + 8) + 0x38) == 0) {
		      return 0;
		    }
		    param1_00 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		    func_ii_7941(param1_00,0);
		    *(undefined4 *)(param1_00 + 0xc) = 7;
		    puVar1 = (undefined4 *)(*(int *)(param1 + 8) + 0x38);
		  }
		  else {
		    if (*(int *)(*(int *)(param1 + 8) + 0x3c) == 0) {
		      return 0;
		    }
		    param1_00 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		    func_ii_7941(param1_00,0);
		    *(undefined4 *)(param1_00 + 0xc) = 0x19;
		    puVar1 = (undefined4 *)(*(int *)(param1 + 8) + 0x3c);
		  }
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),*puVar1,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  *param4 = param1_00;
		  return 1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x74EF", Offset = "0x74EF", VA = "0x74EF")]
		private bool TryGetExpRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
		/* --- GHIDRA: TryGetExpRewards ---
		uint Gameplay_Portals_Model_PortalMonsterData__TryGetExpRewards
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  longlong lVar4;
		  longlong lVar5;
		  longlong lVar6;
		  int iVar7;
		  uint uVar8;
		  uint uVar9;
		  undefined4 local_4;
		  
		  lVar4 = 0;
		  lVar6 = 0;
		  if (DAT_ram_00a58121 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a58121 = '\x01';
		  }
		  local_4 = 0;
		  *param4 = 0;
		  iVar7 = *(int *)(*(int *)(param1 + 8) + 0x14);
		  iVar1 = Core_Data_UserData__set_LevelDic(param2,0);
		  uVar8 = iVar7 - iVar1;
		  if ((int)uVar8 < 0) {
		    iVar1 = Core_Extensions_Dict_DictExt__GetUserSlotsDic(param3,1,0);
		    uVar3 = System_Linq_Enumerable__ToList_uint_
		                      (*(undefined4 *)(iVar1 + 0x10),Method_System_Linq_Enumerable_ToList_ulong___);
		  }
		  else {
		    iVar2 = Core_Extensions_Dict_DictExt__GetUserSlotsDic(param3,2,0);
		    uVar3 = System_Linq_Enumerable__ToList_uint_
		                      (*(undefined4 *)(iVar2 + 0x10),Method_System_Linq_Enumerable_ToList_ulong___);
		    if (iVar7 != iVar1) {
		      iVar1 = Core_Extensions_Dict_DictExt__GetUserSlotsDic(param3,3,0);
		      param1_00 = System_Linq_Enumerable__ToList_uint_
		                            (*(undefined4 *)(iVar1 + 0x10),
		                             Method_System_Linq_Enumerable_ToList_ulong___);
		      lVar6 = System_Collections_Generic_List_ulong___get_Count
		                        (param1_00,0,Method_System_Collections_Generic_List_ulong__get_Item__);
		      lVar6 = lVar6 * (ulonglong)uVar8;
		      lVar4 = System_Collections_Generic_List_ulong___get_Count
		                        (param1_00,3,Method_System_Collections_Generic_List_ulong__get_Item__);
		      lVar4 = lVar4 * (ulonglong)uVar8;
		    }
		  }
		  lVar5 = System_Collections_Generic_List_ulong___get_Count
		                    (uVar3,0,Method_System_Collections_Generic_List_ulong__get_Item__);
		  lVar5 = lVar5 + lVar6;
		  lVar6 = System_Collections_Generic_List_ulong___get_Count
		                    (uVar3,3,Method_System_Collections_Generic_List_ulong__get_Item__);
		  lVar6 = lVar6 + lVar4;
		  uVar3 = func_ii_7504(param2,0);
		  iVar1 = Core_Data_UserData__get_Accounts(uVar3,1,&local_4,0);
		  if (iVar1 != 0) {
		    iVar1 = Core_Extensions_Dict_DictExt__GetUIResourceAssetId(param3,0);
		    lVar6 = lVar6 * (ulonglong)*(uint *)(iVar1 + 0x10);
		    lVar5 = lVar5 * (ulonglong)*(uint *)(iVar1 + 0x10);
		  }
		  if (lVar6 != 0 || lVar5 != 0) {
		    iVar1 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		    func_ii_7941(iVar1,0);
		    *param4 = iVar1;
		    *(undefined4 *)(iVar1 + 0xc) = 0x14;
		    iVar2 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar2,Method_System_Collections_Generic_List_uint___ctor__);
		    iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    iVar7 = *(int *)(iVar2 + 8);
		    uVar8 = *(uint *)(iVar7 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar7 = *(int *)(iVar2 + 8);
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar2 + 0xc);
		    if (uVar9 < uVar8) {
		      *(uint *)(iVar2 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(iVar7 + uVar9 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,0,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    System_Collections_Generic_List_UsageHint___get_Item
		              (iVar2,0,(int)lVar5,Method_System_Collections_Generic_List_uint__set_Item__);
		    System_Collections_Generic_List_UsageHint___get_Item
		              (iVar2,3,(int)lVar6,Method_System_Collections_Generic_List_uint__set_Item__);
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(*param4 + 0x10),iVar2,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		  }
		  return (uint)(lVar6 != 0 || lVar5 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x74F0", Offset = "0x74F0", VA = "0x74F0")]
		private bool TryGetRatingRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
			return default(bool);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x74F1", Offset = "0x74F1", VA = "0x74F1")]
		public PortalMonsterData()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DropChance ---
		int Gameplay_Portals_Model_PortalMonsterData__set_DropChance
		              (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5811d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalMonsterData_TypeInfo);
		    DAT_ram_00a5811d = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Portals_Model_PortalMonsterData_TypeInfo);
		  *(int *)(iVar2 + 0x10) = param1;
		  *(undefined4 *)(iVar2 + 0x14) = param3;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80ea4e22;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ea4e22:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar4 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                    (uVar4,*(undefined4 *)(param1 + 0xc),0);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x80ea4eb4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x80ea4eb4:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar4 = func_ii_7730(*(undefined4 *)(iVar5 + 0x14),*(undefined4 *)(*(int *)(iVar2 + 8) + 0x10),
		                       Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                      );
		  *(undefined4 *)(iVar2 + 0xc) = uVar4;
		  return iVar2;
		}
		*/

}
