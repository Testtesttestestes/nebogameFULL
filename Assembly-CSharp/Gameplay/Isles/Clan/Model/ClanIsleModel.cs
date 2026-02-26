using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Isles.Base.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Common;
using Utils;

namespace Gameplay.Isles.Clan.Model
{
	// Token: 0x02000CF3 RID: 3315
	[Token(Token = "0x2000CF3")]
	public class ClanIsleModel : BaseIsleModel
	{
		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700104E")]
		public ClanData ClanData
		{
			[Token(Token = "0x60050A8")]
			[Address(RVA = "0x9EB7", Offset = "0x9EB7", VA = "0x9EB7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700104F")]
		public BackTime GolemRecoveryBacktime
		{
			[Token(Token = "0x60050A9")]
			[Address(RVA = "0x9EB8", Offset = "0x9EB8", VA = "0x9EB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60050AA")]
			[Address(RVA = "0x9EB9", Offset = "0x9EB9", VA = "0x9EB9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x17001050")]
		public bool GolemHasShield
		{
			[Token(Token = "0x60050AB")]
			[Address(RVA = "0x9EBA", Offset = "0x9EBA", VA = "0x9EBA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001051")]
		public BaseBuildingData GolemBuildingData
		{
			[Token(Token = "0x60050AC")]
			[Address(RVA = "0x9EBB", Offset = "0x9EBB", VA = "0x9EBB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x9EBC", Offset = "0x9EBC", VA = "0x9EBC")]
		public ClanIsleModel(UserData user, ClanData clanData, IDictProvider dictionaries, IGame game)
		{
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x060050AE RID: 20654 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060050AF RID: 20655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001052")]
		public ProtoGetIsleInfoAns.Types.ClanIsleInformation IsleInformation
		{
			[Token(Token = "0x60050AE")]
			[Address(RVA = "0x9EBD", Offset = "0x9EBD", VA = "0x9EBD")]
			get
			{
				return null;
			}
			[Token(Token = "0x60050AF")]
			[Address(RVA = "0x9EBE", Offset = "0x9EBE", VA = "0x9EBE")]
			set
			{
			}
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B0")]
		[Address(RVA = "0x9EBF", Offset = "0x9EBF", VA = "0x9EBF")]
		public void SetGolemRecoveryBacktime(uint value)
		{
		/* --- GHIDRA: SetGolemRecoveryBacktime ---
		undefined4
		Gameplay_Isles_Clan_Model_ClanIsleModel__SetGolemRecoveryBacktime
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int *piVar1;
		  undefined4 uVar2;
		  double param2_00;
		  
		  if (DAT_ram_00a58cb4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58cb4 = '\x01';
		  }
		  piVar1 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(param1 + 0x24),param2,
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x138) * 4))
		                    (piVar1,CONCAT44(in_register_20000014,*(undefined4 *)(*piVar1 + 0x13c)));
		  uVar2 = Protocol_Common_ResourceSet___ctor(uVar2,0);
		  param2_00 = Gameplay_Isles_Clan_Model_ClanIsleModel__Dispose(param1,param1);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__Round(uVar2,param2_00,0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar2,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x9EC0", Offset = "0x9EC0", VA = "0x9EC0")]
		public ResourceSet GetCancelImproveMoneyBack(uint buildingType)
		{
		/* --- GHIDRA: GetCancelImproveMoneyBack ---
		undefined4
		Gameplay_Isles_Clan_Model_ClanIsleModel__GetCancelImproveMoneyBack(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58cb5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58cb5 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f97260;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f97260:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetCult
		                    (uVar3,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x30) + 0x1c) + 0x1c),0);
		  uVar3 = Core_Extensions_Dict_ClanCultDicExt__GetIcon64AssetId(uVar3,0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x9EC1", Offset = "0x9EC1", VA = "0x9EC1")]
		public string GetBgAssetId()
		{
		/* --- GHIDRA: GetBgAssetId ---
		void Gameplay_Isles_Clan_Model_ClanIsleModel__GetBgAssetId(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x18) == '\0') {
		    Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		    *(undefined1 *)(param1 + 0x18) = 1;
		    *(undefined8 *)(param1 + 0x1c) = 0;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x9EC2", Offset = "0x9EC2", VA = "0x9EC2", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		double Gameplay_Isles_Clan_Model_ClanIsleModel__Dispose(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  double dVar2;
		  int *param1_01;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a58cb6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21188);
		    DAT_ram_00a58cb6 = '\x01';
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
		        goto code_r0x80f971ab;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f971ab:
		  param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		  dVar2 = Core_Extensions_Dict_DictExt__GetIntParameter(param1_00,StringLiteral_21188,0);
		  return dVar2;
		}
		*/

		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x17001053")]
		public double BuildingCancelRecoilCoeff
		{
			[Token(Token = "0x60050B4")]
			[Address(RVA = "0x9EC3", Offset = "0x9EC3", VA = "0x9EC3")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x38")]
		private ProtoGetIsleInfoAns.Types.ClanIsleInformation _isleInformation;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_GolemRecoveryBacktime ---
		uint Gameplay_Isles_Clan_Model_ClanIsleModel__set_GolemRecoveryBacktime
		               (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  if (*(int *)(param1 + 0x34) != 0) {
		    fVar1 = func_ii_7103(*(int *)(param1 + 0x34),0);
		    return (uint)(0.0 < fVar1);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_GolemHasShield ---
		undefined4 Gameplay_Isles_Clan_Model_ClanIsleModel__get_GolemHasShield(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a58cb1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    DAT_ram_00a58cb1 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x24) != 0) &&
		     (iVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                        (*(int *)(param1 + 0x24),3,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__ContainsKey__
		                        ), iVar2 != 0)) {
		    uVar1 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(param1 + 0x24),3,
		                       Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                      );
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_GolemBuildingData ---
		void Gameplay_Isles_Clan_Model_ClanIsleModel__get_GolemBuildingData
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined8 uVar1;
		  
		  uVar1 = Gameplay_World_Model_ClanData__set_ClanCultDic(param3,0);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x30) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined8 *)(param1 + 0x10) = uVar1;
		  *(undefined4 *)(param1 + 0x28) = param5;
		  return;
		}
		*/


		/* --- GHIDRA: get_IsleInformation ---
		void Gameplay_Isles_Clan_Model_ClanIsleModel__get_IsleInformation
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  float param2_00;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58cb2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__BaseBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_BuildingInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BuildingInfo__GetEnumerator__);
		    DAT_ram_00a58cb2 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  *(undefined4 *)(param1 + 0x38) = param2;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__BaseBuildingData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0x38) + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_BuildingInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f960e9;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f96407:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9640f;
		    }
		code_r0x80f960e9:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f96407;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x80f96458;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8);
		        if (System_Collections_Generic_IEnumerator_BuildingInfo__TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f961c3;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_BuildingInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f963d5:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9640f;
		    }
		code_r0x80f961c3:
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f963d5;
		    uVar8 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x38) + 0x10) + 0x1c);
		    if (DAT_ram_00a58cea == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Dict_IDictProvider_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a58cea = '\x01';
		        goto code_r0x80f96252;
		      }
		code_r0x80f963df:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9640f;
		    }
		code_r0x80f96252:
		    piVar5 = *(int **)(param1 + 0x1c);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 0xd0);
		          goto code_r0x80f962eb;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f963df;
		code_r0x80f962eb:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f963df;
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x264,uVar1,uVar8,uVar3,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9640f;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		    DAT_ram_009d3e38 = 0;
		    uVar8 = UnityEngine_AndroidJavaObject___GetRawObject(uVar1,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9640f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar3,uVar8,uVar1,
		               Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__set_Item__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f9640f:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar7 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80f96458:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar10 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80f964d0;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar10);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f964d0:
		        (**(code **)((ulonglong)*puVar6 * 4))(CONCAT44(in_register_20000004,piVar5),puVar6[1]);
		      }
		      if (iVar7 == 0) {
		        uVar10 = *(uint *)(*(int *)(param1 + 0x38) + 0x24);
		        if (DAT_ram_00a58cb3 == '\0') {
		          Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		          Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		          DAT_ram_00a58cb3 = '\x01';
		        }
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        param2_00 = func_ii_7331((ulonglong)uVar10,0);
		        uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		        Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,param2_00,0);
		        *(undefined4 *)(param1 + 0x34) = uVar1;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x266,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_IsleInformation ---
		void Gameplay_Isles_Clan_Model_ClanIsleModel__set_IsleInformation
		               (int param1,uint param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58cb3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58cb3 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)param2,0);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x34) = param1_00;
		  return;
		}
		*/

}
