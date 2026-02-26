using System;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public class ClanIsleGolemToolTipView : BaseToolTip<ClanBuildingData>
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x5D0B", Offset = "0x5D0B", VA = "0x5D0B", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_ClanIsleGolemToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanBuildingData___ctor__);
		    DAT_ram_00a5b8e1 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_ClanBuildingData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x5D0C", Offset = "0x5D0C", VA = "0x5D0C")]
		public ClanIsleGolemToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_ClanIsleGolemToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined8 uVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  uint uVar12;
		  int iVar13;
		  int iVar14;
		  int local_8;
		  undefined4 local_4;
		  
		  iVar4 = 0;
		  iVar3 = 0;
		  iVar14 = 0;
		  iVar10 = 0;
		  if (DAT_ram_00a5b8e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanData__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ClanRatingTypes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ClanRatingTypes_var);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_TitlePlaceIconValueBackground___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_15128);
		    DAT_ram_00a5b8e2 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(param1 + 0x14) != 0) {
		    iVar13 = **(int **)(param1 + 0x18);
		    uVar6 = CONCAT44(in_register_20000014,
		                     *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x1c) + 0x18));
		    (**(code **)((ulonglong)*(uint *)(iVar13 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x18),uVar6,*(undefined4 *)(iVar13 + 0x2d4));
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    Gameplay_UserInterface_View_ClanLeagueBannerView__get_ClanData
		              (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x14),0);
		    Gameplay_World_Model_ClanData__TryGetFractionCultDic(*(undefined4 *)(param1 + 0x14),&local_4,0);
		    Gameplay_UserInfo_View_CultView2__get_CultDic(*(undefined4 *)(param1 + 0x20),local_4,0);
		    piVar7 = *(int **)(param1 + 0x24);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_15128,1,0,1,0,0,0,0);
		    iVar13 = *piVar7;
		    uVar6 = CONCAT44(uVar5,uVar1);
		    (**(code **)((ulonglong)*(uint *)(iVar13 + 0x2d0) * 4))
		              (piVar7,uVar6,*(undefined4 *)(iVar13 + 0x2d4));
		    uVar1 = Protocol_Rating_ClanRatingTypes_var;
		    uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    uVar1 = func_ii_2734(uVar1,0);
		    if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a6697c);
		    }
		    iVar13 = System_Enum__GetUnderlyingType(uVar1,0);
		    uVar1 = Protocol_Rating_ClanRatingTypes___TypeInfo;
		    if ((iVar13 != 0) &&
		       (iVar3 = func_ii_1082(iVar13,Protocol_Rating_ClanRatingTypes___TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(iVar13,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar13 = *(int *)(iVar3 + 0xc);
		    if (0 < iVar13) {
		      do {
		        iVar8 = *(int *)(iVar3 + iVar14 * 4 + 0x10);
		        if (iVar8 != 0) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar9 = *piVar7;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar12 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		                puVar2 = (uint *)(piVar11[1] * 8 + iVar9 + 0x178);
		                goto code_r0x81390511;
		              }
		              uVar12 = uVar12 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		          }
		          puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81390511:
		          uVar6 = CONCAT44(uVar5,puVar2[1]);
		          uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar6);
		          uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		          uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		          iVar8 = Core_Extensions_Dict_DictExt__GetUserRatingKindDic(uVar1,iVar8,0);
		          if ((iVar8 != 0) && (*(char *)(iVar8 + 0x10) != '\0')) {
		            uVar6 = func_ii_7271(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x1c) + 0x24),
		                                 iVar4,
		                                 Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		            uVar5 = *(undefined4 *)(param1 + 0x2c);
		            uVar1 = *(undefined4 *)(param1 + 0x28);
		            if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		              func_ii_306000(UnityEngine_Object_TypeInfo);
		            }
		            piVar7 = (int *)func_ii_6805(uVar1,uVar5,
		                                         Method_UnityEngine_Object_Instantiate_TitlePlaceIconValueBackground___
		                                        );
		            Google_Protobuf_Collections_RepeatedField_ulong___get_Item(piVar7,iVar4,0);
		            uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (piVar7,0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar5,1,0);
		            (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe0) * 4))
		                      (piVar7,uVar6,*(undefined4 *)(*piVar7 + 0xe4));
		            uVar5 = (undefined4)((ulonglong)uVar6 >> 0x20);
		            uVar1 = Core_Extensions_Dict_ClanRatingKindDicExt__GetButton128AssetId(iVar8,0);
		            Core_Extensions_Dict_UserRatingKindDicExt__GetTitle(piVar7,uVar1,0);
		            uVar1 = Core_Extensions_Dict_ClanLeagueDicExt__GetIconAssetId(iVar8,0);
		            Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId(piVar7,uVar1,0);
		            uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x1c) + 0x28),
		                               iVar4,
		                               Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            Gameplay_UserInfo_View_TitleIconValueBackground___ctor(piVar7,uVar1,0);
		            iVar4 = iVar4 + 1;
		          }
		        }
		        iVar14 = iVar14 + 1;
		      } while (iVar14 != iVar13);
		    }
		    Google_Protobuf_Collections_RepeatedField_ulong___get_Item
		              (*(undefined4 *)(param1 + 0x30),iVar4,0);
		    piVar7 = *(int **)(param1 + 0x30);
		    iVar3 = Core_Extensions_ClanInfoExt__GetHonorRating
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x1c),0);
		    iVar14 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar14 + 0xe0) * 4))
		              (piVar7,(longlong)iVar3,*(undefined4 *)(iVar14 + 0xe4));
		    Google_Protobuf_Collections_RepeatedField_ulong___get_Item
		              (*(undefined4 *)(param1 + 0x34),iVar4 + 1,0);
		    piVar7 = *(int **)(param1 + 0x34);
		    iVar3 = Core_Extensions_ClanInfoExt__GetLegendMembersNum
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x1c),0);
		    iVar14 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar14 + 0xe0) * 4))
		              (piVar7,(longlong)iVar3,*(undefined4 *)(iVar14 + 0xe4));
		    Google_Protobuf_Collections_RepeatedField_ulong___get_Item
		              (*(undefined4 *)(param1 + 0x38),iVar4 + 2,0);
		    piVar7 = *(int **)(param1 + 0x38);
		    iVar4 = Core_Extensions_ClanInfoExt__GetTotalMembersNum
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x1c),0);
		    iVar3 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar7,(longlong)iVar4,*(undefined4 *)(iVar3 + 0xe4));
		    iVar4 = Gameplay_World_Model_ClanData__set_ClanLeagueDic(*(undefined4 *)(param1 + 0x14),0);
		    local_8 = *(int *)(iVar4 + 0xc);
		    uVar1 = *(undefined4 *)(param1 + 0x3c);
		    uVar5 = func_ii_4443(&local_8,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar5,0);
		    iVar4 = *(int *)(param1 + 0x40);
		    if (0 < *(int *)(iVar4 + 0xc)) {
		      do {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (*(undefined4 *)(iVar4 + iVar10 * 4 + 0x10),(uint)(0 < local_8),0);
		        iVar10 = iVar10 + 1;
		      } while (iVar10 < *(int *)(iVar4 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanIsleGolemToolTipView";

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;
	}
}
