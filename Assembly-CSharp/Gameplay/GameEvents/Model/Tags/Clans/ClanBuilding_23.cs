using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Clans
{
	// Token: 0x020007C4 RID: 1988
	[Token(Token = "0x20007C4")]
	public class ClanBuilding_23 : AbstractTag
	{
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x1700091D")]
		public uint BuildingType
		{
			[Token(Token = "0x6002ED2")]
			[Address(RVA = "0x7F41", Offset = "0x7F41", VA = "0x7F41")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x1700091E")]
		public uint BuildingLevel
		{
			[Token(Token = "0x6002ED3")]
			[Address(RVA = "0x7F42", Offset = "0x7F42", VA = "0x7F42")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x1700091F")]
		public uint Cult
		{
			[Token(Token = "0x6002ED4")]
			[Address(RVA = "0x7F43", Offset = "0x7F43", VA = "0x7F43")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x7F44", Offset = "0x7F44", VA = "0x7F44", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x7F45", Offset = "0x7F45", VA = "0x7F45")]
		public ClanBuilding_23()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GameEvents_Model_Tags_Clans_ClanBuilding_23___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  double dVar3;
		  
		  dVar3 = *(double *)(*(int *)(param1 + 0x14) + 0x10);
		  if (dVar3 < 4294967296.0 && 0.0 <= dVar3) {
		    iVar1 = (int)dVar3;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (2147483648.0 <= ABS(dVar3)) {
		    iVar2 = -0x80000000;
		    if (0.0 <= dVar3) {
		      iVar2 = iVar1;
		    }
		    return iVar2;
		  }
		  iVar2 = (int)dVar3;
		  if (0.0 <= dVar3) {
		    iVar2 = iVar1;
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x040019A1 RID: 6561
		[Token(Token = "0x40019A1")]
		public const string TITLE = "clan_building_title";

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		public const string LEVEL = "clan_building_level";

		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		public const string BUILDING_WIDGET = "clan_building_view";

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		public const string VIEW_PREFAB_PATH = "BuildingTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BuildingType ---
		int Gameplay_GameEvents_Model_Tags_Clans_ClanBuilding_23__get_BuildingType
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  double dVar3;
		  
		  dVar3 = *(double *)(*(int *)(param1 + 0x14) + 0x18);
		  if (dVar3 < 4294967296.0 && 0.0 <= dVar3) {
		    iVar1 = (int)dVar3;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (2147483648.0 <= ABS(dVar3)) {
		    iVar2 = -0x80000000;
		    if (0.0 <= dVar3) {
		      iVar2 = iVar1;
		    }
		    return iVar2;
		  }
		  iVar2 = (int)dVar3;
		  if (0.0 <= dVar3) {
		    iVar2 = iVar1;
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: get_BuildingLevel ---
		int Gameplay_GameEvents_Model_Tags_Clans_ClanBuilding_23__get_BuildingLevel
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  double dVar3;
		  
		  dVar3 = *(double *)(*(int *)(param1 + 0x14) + 0x20);
		  if (dVar3 < 4294967296.0 && 0.0 <= dVar3) {
		    iVar1 = (int)dVar3;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (2147483648.0 <= ABS(dVar3)) {
		    iVar2 = -0x80000000;
		    if (0.0 <= dVar3) {
		      iVar2 = iVar1;
		    }
		    return iVar2;
		  }
		  iVar2 = (int)dVar3;
		  if (0.0 <= dVar3) {
		    iVar2 = iVar1;
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: get_Cult ---
		int Gameplay_GameEvents_Model_Tags_Clans_ClanBuilding_23__get_Cult
		              (int *param1,undefined4 param2,undefined4 param3,int *param4,int param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int param4_00;
		  int iVar5;
		  int param3_00;
		  double dVar6;
		  double dVar7;
		  double dVar8;
		  uint uVar9;
		  int iVar10;
		  int local_4;
		  
		  if (DAT_ram_00a574f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_LoaderTagView___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4011);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21189);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21191);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21192);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574f8 = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		  }
		  else {
		    iVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = iVar3;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21191,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21189,0);
		      if (iVar3 == 0) {
		        iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21192,0);
		        if ((iVar3 != 0) && (*param4 = StringLiteral_5, param5 != 0)) {
		          uVar1 = Unity_Properties_PropertyMember___ctor
		                            (2,Core_Dict_IDictProvider_TypeInfo,param1[2]);
		          iVar3 = param1[5];
		          dVar6 = *(double *)(iVar3 + 0x20);
		          if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		            iVar10 = (int)dVar6;
		          }
		          else {
		            iVar10 = 0;
		          }
		          if (ABS(dVar6) < 2147483648.0) {
		            param4_00 = (int)dVar6;
		          }
		          else {
		            param4_00 = -0x80000000;
		          }
		          dVar7 = *(double *)(iVar3 + 0x18);
		          if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		            iVar5 = (int)dVar7;
		          }
		          else {
		            iVar5 = 0;
		          }
		          if (ABS(dVar7) < 2147483648.0) {
		            param3_00 = (int)dVar7;
		          }
		          else {
		            param3_00 = -0x80000000;
		          }
		          dVar8 = *(double *)(iVar3 + 0x10);
		          if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		            iVar3 = (int)dVar8;
		          }
		          else {
		            iVar3 = 0;
		          }
		          if (0.0 <= dVar6) {
		            param4_00 = iVar10;
		          }
		          if (0.0 <= dVar7) {
		            param3_00 = iVar5;
		          }
		          if (ABS(dVar8) < 2147483648.0) {
		            iVar10 = (int)dVar8;
		          }
		          else {
		            iVar10 = -0x80000000;
		          }
		          if (0.0 <= dVar8) {
		            iVar10 = iVar3;
		          }
		          uVar1 = Core_Extensions_Dict_DictExt__GetGiftDic(uVar1,iVar10,param3_00,param4_00,0);
		          param1_00 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                                (param1,StringLiteral_4011,*(undefined4 *)(param5 + 8),
		                                 Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_LoaderTagView___
		                                );
		          param2_00 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetAnimationAssetId(uVar1,0);
		          Gameplay_GameEvents_View_Tags_CollectionTagView___ctor(param1_00,param2_00,uVar1);
		        }
		      }
		      else {
		        dVar6 = *(double *)(param1[5] + 0x18);
		        if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		          iVar3 = (int)dVar6;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar6) < 2147483648.0) {
		          local_4 = (int)dVar6;
		        }
		        else {
		          local_4 = -0x80000000;
		        }
		        if (0.0 <= dVar6) {
		          local_4 = iVar3;
		        }
		        iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		        if (iVar3 == 0) {
		          iVar3 = StringLiteral_5;
		        }
		        *param4 = iVar3;
		      }
		    }
		    else {
		      param1_01 = (int *)param1[2];
		      iVar3 = *param1_01;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar9 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d99e94;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar9);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d99e94:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		      dVar6 = *(double *)(param1[5] + 0x10);
		      if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		        iVar3 = (int)dVar6;
		      }
		      else {
		        iVar3 = 0;
		      }
		      if (ABS(dVar6) < 2147483648.0) {
		        iVar10 = (int)dVar6;
		      }
		      else {
		        iVar10 = -0x80000000;
		      }
		      if (0.0 <= dVar6) {
		        iVar10 = iVar3;
		      }
		      uVar1 = Core_Extensions_Dict_DictExt__GetClanBuildingView(uVar1,iVar10,0);
		      iVar3 = Core_Extensions_Dict_ChatSmileDicExt__GetTitle(uVar1,0);
		      *param4 = iVar3;
		    }
		  }
		  return iVar2;
		}
		*/

}
