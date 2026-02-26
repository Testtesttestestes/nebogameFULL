using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Accounts.Model.Data;
using Gameplay.Isles.Base.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.World;

namespace Gameplay.Isles.User.Model
{
	// Token: 0x02000D2C RID: 3372
	[Token(Token = "0x2000D2C")]
	public class UserIsleModel : BaseIsleModel, IMonsterSource
	{
		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x0600526C RID: 21100 RVA: 0x0000EF58 File Offset: 0x0000D158
		// (set) Token: 0x0600526D RID: 21101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C7")]
		public int RequestFlags
		{
			[Token(Token = "0x600526C")]
			[Address(RVA = "0xA043", Offset = "0xA043", VA = "0xA043")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600526D")]
			[Address(RVA = "0xA044", Offset = "0xA044", VA = "0xA044")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x0600526E RID: 21102 RVA: 0x0000EF70 File Offset: 0x0000D170
		[Token(Token = "0x170010C8")]
		public ulong OwnerId
		{
			[Token(Token = "0x600526E")]
			[Address(RVA = "0xA045", Offset = "0xA045", VA = "0xA045", Slot = "6")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x0000EF88 File Offset: 0x0000D188
		// (set) Token: 0x06005270 RID: 21104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C9")]
		public bool IsLicenceSpent
		{
			[Token(Token = "0x600526F")]
			[Address(RVA = "0xA046", Offset = "0xA046", VA = "0xA046")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005270")]
			[Address(RVA = "0xA047", Offset = "0xA047", VA = "0xA047")]
			set
			{
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06005271 RID: 21105 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		// (set) Token: 0x06005272 RID: 21106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CA")]
		public bool IsDiamondIsle
		{
			[Token(Token = "0x6005271")]
			[Address(RVA = "0xA048", Offset = "0xA048", VA = "0xA048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005272")]
			[Address(RVA = "0xA049", Offset = "0xA049", VA = "0xA049")]
			set
			{
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x170010CB")]
		public Resources IsleBonusResourceType
		{
			[Token(Token = "0x6005273")]
			[Address(RVA = "0xA04A", Offset = "0xA04A", VA = "0xA04A")]
			get
			{
				return Resources.UnknownResource;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005275 RID: 21109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CC")]
		public ProtoGetUserIsleInfoAns.Types.IsleInformation IsleInformation
		{
			[Token(Token = "0x6005274")]
			[Address(RVA = "0xA04B", Offset = "0xA04B", VA = "0xA04B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005275")]
			[Address(RVA = "0xA04C", Offset = "0xA04C", VA = "0xA04C")]
			set
			{
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005277 RID: 21111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CD")]
		public IsleInfoDic IsleInfoDic
		{
			[Token(Token = "0x6005276")]
			[Address(RVA = "0xA04D", Offset = "0xA04D", VA = "0xA04D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005277")]
			[Address(RVA = "0xA04E", Offset = "0xA04E", VA = "0xA04E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005279 RID: 21113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CE")]
		public ClanData BackClanData
		{
			[Token(Token = "0x6005278")]
			[Address(RVA = "0xA04F", Offset = "0xA04F", VA = "0xA04F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005279")]
			[Address(RVA = "0xA050", Offset = "0xA050", VA = "0xA050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600527B RID: 21115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010CF")]
		public MonsterData Monster
		{
			[Token(Token = "0x600527A")]
			[Address(RVA = "0xA051", Offset = "0xA051", VA = "0xA051", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600527B")]
			[Address(RVA = "0xA052", Offset = "0xA052", VA = "0xA052")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		// (set) Token: 0x0600527D RID: 21117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D0")]
		public bool IsHorde
		{
			[Token(Token = "0x600527C")]
			[Address(RVA = "0xA053", Offset = "0xA053", VA = "0xA053")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600527D")]
			[Address(RVA = "0xA054", Offset = "0xA054", VA = "0xA054")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600527F RID: 21119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D1")]
		public UserData LoggedUser
		{
			[Token(Token = "0x600527E")]
			[Address(RVA = "0xA055", Offset = "0xA055", VA = "0xA055")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600527F")]
			[Address(RVA = "0xA056", Offset = "0xA056", VA = "0xA056")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005281 RID: 21121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D2")]
		public List<UserIsleAccountMarkerData> CurrentAccountMarkers
		{
			[Token(Token = "0x6005280")]
			[Address(RVA = "0xA057", Offset = "0xA057", VA = "0xA057")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005281")]
			[Address(RVA = "0xA058", Offset = "0xA058", VA = "0xA058")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005282")]
		[Address(RVA = "0xA059", Offset = "0xA059", VA = "0xA059", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_User_Model_UserIsleModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 param1_00;
		  undefined8 uVar1;
		  
		  if (DAT_ram_00a58d84 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_UserIsleAccountMarkerData__TypeInfo);
		    DAT_ram_00a58d84 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_UserIsleAccountMarkerData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_UserIsleAccountMarkerData___ctor__);
		  *(undefined4 *)(param1 + 0x50) = param1_00;
		  uVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x4c) = param4;
		  *(undefined4 *)(param1 + 0x48) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined8 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0x28) = param6;
		  return;
		}
		*/

		}

		// Token: 0x06005283 RID: 21123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005283")]
		[Address(RVA = "0xA05A", Offset = "0xA05A", VA = "0xA05A")]
		public UserIsleModel(UserData user, UserData loggedUser, IAccountDataDecorator[] availAccountMarkers, IDictProvider dictionaries, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		double Gameplay_Isles_User_Model_UserIsleModel___ctor(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  double dVar2;
		  int *param1_01;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a58d86 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20789);
		    DAT_ram_00a58d86 = '\x01';
		  }
		  if (DAT_ram_00a58cea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58cea = '\x01';
		  }
		  uVar4 = 0;
		  param1_01 = *(int **)(param1 + 0x1c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80fa5c86;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80fa5c86:
		  param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		  dVar2 = Core_Extensions_Dict_DictExt__GetIntParameter(param1_00,StringLiteral_20789,0);
		  return dVar2;
		}
		*/

		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005284")]
		[Address(RVA = "0x1C9C", Offset = "0x1C9C", VA = "0x1C9C")]
		public void SetMonster(MonsterInfo monsterInfo)
		{
		/* --- GHIDRA: SetMonster ---
		int * Gameplay_Isles_User_Model_UserIsleModel__SetMonster(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[Token(Token = "0x170010D3")]
		public double BuildingCancelRecoilCoeff
		{
			[Token(Token = "0x6005285")]
			[Address(RVA = "0xA05B", Offset = "0xA05B", VA = "0xA05B")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		[FieldOffset(Offset = "0x34")]
		private ProtoGetUserIsleInfoAns.Types.IsleInformation _isleInformation;

		// Token: 0x04002CE8 RID: 11496
		[Token(Token = "0x4002CE8")]
		[FieldOffset(Offset = "0x4C")]
		public readonly IAccountDataDecorator[] AvailAccountMarkers;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_RequestFlags ---
		undefined8 Gameplay_Isles_User_Model_UserIsleModel__set_RequestFlags(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  
		  uVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_OwnerId ---
		undefined4 Gameplay_Isles_User_Model_UserIsleModel__get_OwnerId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (*(int *)(param1 + 0x34) == 0) {
		    uVar1 = 0;
		  }
		  else {
		    local_4 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0x10);
		    uVar1 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,1,0);
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsLicenceSpent ---
		void Gameplay_Isles_User_Model_UserIsleModel__get_IsLicenceSpent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0x10);
		  Core_Extensions_TransformExt__SetBottom(&local_4,1,0);
		  *(undefined4 *)(*(int *)(param1 + 0x34) + 0x10) = local_4;
		  return;
		}
		*/


		/* --- GHIDRA: set_IsLicenceSpent ---
		undefined4 Gameplay_Isles_User_Model_UserIsleModel__set_IsLicenceSpent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (*(int *)(param1 + 0x34) == 0) {
		    uVar1 = 0;
		  }
		  else {
		    local_4 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0x10);
		    uVar1 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,2,0);
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsDiamondIsle ---
		void Gameplay_Isles_User_Model_UserIsleModel__get_IsDiamondIsle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0x10);
		  Core_Extensions_TransformExt__SetBottom(&local_4,2,0);
		  *(undefined4 *)(*(int *)(param1 + 0x34) + 0x10) = local_4;
		  return;
		}
		*/


		/* --- GHIDRA: set_IsDiamondIsle ---
		undefined4 Gameplay_Isles_User_Model_UserIsleModel__set_IsDiamondIsle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (*(int *)(param1 + 0x34) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    local_4 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0x10);
		    iVar1 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,2,0);
		    if (iVar1 == 0) {
		      if (*(int *)(param1 + 0x34) == 0) {
		        uVar2 = 0;
		      }
		      else {
		        uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0x14);
		      }
		    }
		    else {
		      uVar2 = 2;
		    }
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_IsleInformation ---
		void Gameplay_Isles_User_Model_UserIsleModel__get_IsleInformation
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58d83 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__BaseBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_UserBuildingInfo__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserBuildingInfo__GetEnumerator__);
		    DAT_ram_00a58d83 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  *(int *)(param1 + 0x34) = param2;
		  if (param2 == 0) {
		    return;
		  }
		  if (DAT_ram_00a58cea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58cea = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 0x1c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x80fa53b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80fa53b8:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetClanCult
		                    (uVar3,*(undefined4 *)(*(int *)(param1 + 0x34) + 0x28),0);
		  *(undefined4 *)(param1 + 0x38) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__BaseBuildingData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar3;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0x34) + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_UserBuildingInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80fa54d6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80fa57fe:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa5806;
		    }
		code_r0x80fa54d6:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80fa57fe;
		    if (iVar8 == 0) {
		      iVar6 = 5;
		      iVar8 = 0;
		      goto code_r0x80fa5853;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_UserBuildingInfo__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80fa55b0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UserBuildingInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80fa57cc:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa5806;
		    }
		code_r0x80fa55b0:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80fa57cc;
		    if (DAT_ram_00a58cea == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Dict_IDictProvider_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a58cea = '\x01';
		        goto code_r0x80fa5632;
		      }
		code_r0x80fa57d6:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa5806;
		    }
		code_r0x80fa5632:
		    piVar7 = *(int **)(param1 + 0x1c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 0xd0);
		          goto code_r0x80fa56cb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80fa57d6;
		code_r0x80fa56cb:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80fa57d6;
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x27d,uVar3,uVar5,0
		                              );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa5806;
		    }
		    uVar5 = *(undefined4 *)(param1 + 0x24);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*piVar7 + 0x150),piVar7,*(undefined4 *)(*piVar7 + 0x154));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa5806;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar5,uVar3,piVar7,
		               Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__set_Item__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa5806:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar8 = *piVar7;
		    iVar6 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x80fa5853:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80fa58cb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80fa58cb:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar6 != 0) {
		        if (iVar6 == 1) {
		          return;
		        }
		        if (iVar6 == 2) {
		          return;
		        }
		        if (iVar6 == 3) {
		          return;
		        }
		        if (iVar6 == 4) {
		          return;
		        }
		        if (iVar6 != 5) {
		          return;
		        }
		      }
		      iVar8 = *(int *)(param1 + 0x34);
		      iVar6 = *(int *)(iVar8 + 0x38);
		      if (iVar6 != 0) {
		        if (DAT_ram_00a58cea == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		          DAT_ram_00a58cea = '\x01';
		        }
		        piVar7 = *(int **)(param1 + 0x1c);
		        iVar8 = *piVar7;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0)
		              ;
		              goto code_r0x80fa59c2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80fa59c2:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		        uVar3 = func_ii_7325(iVar6,uVar3,0);
		        *(undefined4 *)(param1 + 0x3c) = uVar3;
		        iVar8 = *(int *)(param1 + 0x34);
		      }
		      func_ii_7323(param1,*(undefined4 *)(iVar8 + 0x24),iVar8);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x27e,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_CurrentAccountMarkers ---
		void Gameplay_Isles_User_Model_UserIsleModel__set_CurrentAccountMarkers
		               (int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x18) == '\0') {
		    Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		    *(undefined4 *)(param1 + 0x40) = 0;
		    *(undefined1 *)(param1 + 0x18) = 1;
		    *(undefined8 *)(param1 + 0x1c) = 0;
		    *(undefined4 *)(param1 + 0x24) = 0;
		    *(undefined8 *)(param1 + 0x38) = 0;
		    if (DAT_ram_00a58d83 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData___ctor__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__set_Item__);
		      Mono_Security_ASN1__get_Item
		                (&System_Collections_Generic_Dictionary_uint__BaseBuildingData__TypeInfo);
		      Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&System_Collections_Generic_IEnumerator_UserBuildingInfo__TypeInfo);
		      Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_UserBuildingInfo__GetEnumerator__
		                );
		      DAT_ram_00a58d83 = '\x01';
		    }
		    *(undefined4 *)(param1 + 0x48) = 0;
		    *(undefined4 *)(param1 + 0x34) = 0;
		  }
		  return;
		}
		*/

}
