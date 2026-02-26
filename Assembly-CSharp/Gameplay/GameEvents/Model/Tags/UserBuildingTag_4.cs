using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	public class UserBuildingTag_4 : AbstractTag
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002EAA RID: 11946 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x17000912")]
		public uint BuildingViewId
		{
			[Token(Token = "0x6002EAA")]
			[Address(RVA = "0x7F25", Offset = "0x7F25", VA = "0x7F25")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x7F26", Offset = "0x7F26", VA = "0x7F26", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x7F27", Offset = "0x7F27", VA = "0x7F27")]
		public UserBuildingTag_4()
		{
		}

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		public const string BUILDING_TITLE = "building_title";

		// Token: 0x04001991 RID: 6545
		[Token(Token = "0x4001991")]
		public const string BUILDING_LEVEL = "building_level";

		// Token: 0x04001992 RID: 6546
		[Token(Token = "0x4001992")]
		public const string BUILDING_VIEW = "building_view";

		// Token: 0x04001993 RID: 6547
		[Token(Token = "0x4001993")]
		public const string VIEW_PREFAB_PATH = "BuildingTagView";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BuildingViewId ---
		int Gameplay_GameEvents_Model_Tags_UserBuildingTag_4__get_BuildingViewId
		              (int *param1,undefined4 param2,undefined4 param3,int *param4,int param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar5;
		  int iVar6;
		  double dVar7;
		  uint uVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_LoaderTagView___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20791);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4011);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20793);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574e8 = '\x01';
		  }
		  local_4 = 0;
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
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_20791,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_20790,0);
		      if (iVar3 == 0) {
		        iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_20793,0);
		        if ((iVar3 != 0) && (*param4 = StringLiteral_5, param5 != 0)) {
		          uVar1 = Unity_Properties_PropertyMember___ctor
		                            (2,Core_Dict_IDictProvider_TypeInfo,param1[2]);
		          dVar7 = *(double *)(param1[5] + 0x10);
		          if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		            iVar3 = (int)dVar7;
		          }
		          else {
		            iVar3 = 0;
		          }
		          if (ABS(dVar7) < 2147483648.0) {
		            iVar6 = (int)dVar7;
		          }
		          else {
		            iVar6 = -0x80000000;
		          }
		          if (0.0 <= dVar7) {
		            iVar6 = iVar3;
		          }
		          uVar1 = Core_Extensions_Dict_DictExt__GetUserBuildingTypeDic(uVar1,iVar6,0);
		          param1_00 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                                (param1,StringLiteral_4011,*(undefined4 *)(param5 + 8),
		                                 Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_LoaderTagView___
		                                );
		          param2_00 = Core_Extensions_Dict_UserBuildingViewsDicExt__GetImageAssetId(uVar1,0);
		          Gameplay_GameEvents_View_Tags_CollectionTagView___ctor(param1_00,param2_00,uVar1);
		        }
		      }
		      else {
		        uVar8 = 0;
		        piVar5 = (int *)param1[2];
		        iVar3 = *piVar5;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + iVar3 + 0xd0)
		              ;
		              goto code_r0x80d98374;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d98374:
		        uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		        dVar7 = *(double *)(param1[5] + 0x10);
		        if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		          iVar3 = (int)dVar7;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar7) < 2147483648.0) {
		          iVar6 = (int)dVar7;
		        }
		        else {
		          iVar6 = -0x80000000;
		        }
		        if (0.0 <= dVar7) {
		          iVar6 = iVar3;
		        }
		        iVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingTypeDic(uVar1,iVar6,0);
		        local_4 = *(undefined4 *)(iVar3 + 0x14);
		        iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		        if (iVar3 == 0) {
		          iVar3 = StringLiteral_5;
		        }
		        *param4 = iVar3;
		      }
		    }
		    else {
		      piVar5 = (int *)param1[2];
		      iVar3 = *piVar5;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d981e8;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d981e8:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      dVar7 = *(double *)(param1[5] + 0x10);
		      if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		        iVar3 = (int)dVar7;
		      }
		      else {
		        iVar3 = 0;
		      }
		      uVar8 = 0;
		      if (ABS(dVar7) < 2147483648.0) {
		        iVar6 = (int)dVar7;
		      }
		      else {
		        iVar6 = -0x80000000;
		      }
		      if (0.0 <= dVar7) {
		        iVar6 = iVar3;
		      }
		      iVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingTypeDic(uVar1,iVar6,0);
		      piVar5 = (int *)param1[2];
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x80d982d8;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d982d8:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      uVar1 = Core_Extensions_Dict_DictExt__GetIsleInfoDicByUserId
		                        (uVar1,*(undefined4 *)(iVar3 + 0x10),0);
		      iVar3 = Core_Extensions_Dict_TutorialUIPointerDicExt__GetView(uVar1,0);
		      *param4 = iVar3;
		    }
		  }
		  return iVar2;
		}
		*/

}
