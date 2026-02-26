using System;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000409 RID: 1033
	[Token(Token = "0x2000409")]
	public class UserRatingView : BaseInfoBox
	{
		// Token: 0x0600184A RID: 6218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x69FE", Offset = "0x69FE", VA = "0x69FE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInfo_View_UserRatingView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined8 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  uint param2_00;
		  int iVar11;
		  uint uVar12;
		  
		  param2_00 = 0;
		  iVar3 = 0;
		  iVar11 = 0;
		  if (DAT_ram_00a598fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TitleIconValueBackground___)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_UserRatingTypes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_UserRatingTypes_var);
		    DAT_ram_00a598fe = '\x01';
		  }
		  if (*(char *)(param1 + 0x14) != '\0') {
		    Gameplay_UserInfo_View_BaseInfoBox__SwitchVisible(param1,0);
		    uVar1 = Protocol_Rating_UserRatingTypes_var;
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    uVar1 = func_ii_2734(uVar1,0);
		    if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a6697c);
		    }
		    iVar2 = System_Enum__GetUnderlyingType(uVar1,0);
		    uVar1 = Protocol_Rating_UserRatingTypes___TypeInfo;
		    if ((iVar2 != 0) &&
		       (iVar3 = func_ii_1082(iVar2,Protocol_Rating_UserRatingTypes___TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = *(int *)(iVar3 + 0xc);
		    if (0 < iVar2) {
		      do {
		        iVar6 = *(int *)(iVar3 + iVar11 * 4 + 0x10);
		        if (iVar6 != 0) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar8 = *piVar7;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar12 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar12 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		                puVar4 = (uint *)(piVar10[1] * 8 + iVar8 + 0x178);
		                goto code_r0x8108c895;
		              }
		              uVar12 = uVar12 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar12);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108c895:
		          uVar5 = CONCAT44(in_register_20000014,puVar4[1]);
		          uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,uVar5);
		          in_register_20000014 = (undefined4)((ulonglong)uVar5 >> 0x20);
		          uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		          iVar6 = Core_Extensions_Dict_DictExt__GetExperienceDic(uVar1,iVar6,0);
		          if (iVar6 != 0) {
		            uVar5 = func_ii_7271(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x34) + 0x34),
		                                 param2_00,
		                                 Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__)
		            ;
		            uVar1 = *(undefined4 *)(param1 + 0x10);
		            uVar9 = *(undefined4 *)(param1 + 0x18);
		            if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		              func_ii_306000(UnityEngine_Object_TypeInfo);
		            }
		            piVar7 = (int *)func_ii_6805(uVar9,uVar1,
		                                         Method_UnityEngine_Object_Instantiate_TitleIconValueBackground___
		                                        );
		            piVar7[10] = param2_00;
		            iVar8 = 0x10;
		            if ((param2_00 & 1) == 0) {
		              iVar8 = 0x14;
		            }
		            func_ii_7050(piVar7[6],*(undefined4 *)((int)piVar7 + iVar8),0);
		            uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (piVar7,0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar1,1,0);
		            (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe0) * 4))
		                      (piVar7,uVar5,*(undefined4 *)(*piVar7 + 0xe4));
		            uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		            uVar9 = Gameplay_UserInfo_View_TitleIconValueBackground__set_Index(iVar6,0);
		            if (DAT_ram_00a598e9 == '\0') {
		              Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		              DAT_ram_00a598e9 = '\x01';
		            }
		            piVar10 = (int *)piVar7[7];
		            uVar9 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar9,StringLiteral_2003,0);
		            iVar8 = *piVar10;
		            uVar5 = CONCAT44(uVar1,uVar9);
		            (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		                      (piVar10,uVar5,*(undefined4 *)(iVar8 + 0x2d4));
		            in_register_20000014 = (undefined4)((ulonglong)uVar5 >> 0x20);
		            uVar1 = Gameplay_UserInfo_View_TitleIconValueBackground__SetTitle(iVar6,0);
		            Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(piVar7[9],uVar1,0);
		            param2_00 = param2_00 + 1;
		          }
		        }
		        iVar11 = iVar11 + 1;
		      } while (iVar11 != iVar2);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x69FF", Offset = "0x69FF", VA = "0x69FF", Slot = "5")]
		public override void UpdateInfo()
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x6A00", Offset = "0x6A00", VA = "0x6A00")]
		public UserRatingView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_UserRatingView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a598ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig___ctor__
		              );
		    DAT_ram_00a598ff = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TitleIconValueBackground _listElementPrefab;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x1C")]
		public UserData User;
	}
}
