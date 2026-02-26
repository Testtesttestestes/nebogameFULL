using System;
using System.Runtime.CompilerServices;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Dic;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x2000A45")]
	public class ClanOfficeData
	{
		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C78")]
		public ProtoGetIsleInfoAns.Types.ClanIsleInformation ClanIsleInformation
		{
			[Token(Token = "0x6003E3C")]
			[Address(RVA = "0x8CFB", Offset = "0x8CFB", VA = "0x8CFB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E3D")]
			[Address(RVA = "0x8CFC", Offset = "0x8CFC", VA = "0x8CFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06003E3E RID: 15934 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003E3F RID: 15935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C79")]
		public ClanData ClanData
		{
			[Token(Token = "0x6003E3E")]
			[Address(RVA = "0x8CFD", Offset = "0x8CFD", VA = "0x8CFD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003E3F")]
			[Address(RVA = "0x8CFE", Offset = "0x8CFE", VA = "0x8CFE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06003E40 RID: 15936 RVA: 0x0000C480 File Offset: 0x0000A680
		// (set) Token: 0x06003E41 RID: 15937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7A")]
		public int MembersCount
		{
			[Token(Token = "0x6003E40")]
			[Address(RVA = "0x8CFF", Offset = "0x8CFF", VA = "0x8CFF")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003E41")]
			[Address(RVA = "0x8D00", Offset = "0x8D00", VA = "0x8D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E42")]
		[Address(RVA = "0x8D01", Offset = "0x8D01", VA = "0x8D01")]
		private ClanOfficeData()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Clans_Office_Model_ClanOfficeData___ctor
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57f95 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_ClanOfficeData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a57f95 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Clans_Office_Model_ClanOfficeData_TypeInfo);
		  *(int *)(iVar2 + 8) = param1;
		  uVar3 = func_ii_7325(*(undefined4 *)(param1 + 0x10),param2,0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar3;
		  uVar3 = Core_Extensions_ClanInfoExt__GetHonorRating(*(undefined4 *)(param1 + 0x10),0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  if (*(int *)(param1 + 0x2c) != 0) {
		    iVar5 = *(int *)(iVar2 + 0xc);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		          goto code_r0x80e869ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e869ae:
		    iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    piVar6 = *(int **)(iVar7 + 0x14);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e86a3a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80e86a3a:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		    *(undefined4 *)(iVar5 + 0x14) = uVar3;
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003E43")]
		[Address(RVA = "0x8D02", Offset = "0x8D02", VA = "0x8D02")]
		public static ClanOfficeData Create(ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInformation, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Create ---
		void Gameplay_Clans_Office_Model_ClanOfficeData__Create
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a57f96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_RatingElements_SubRatings_SubRatingsListArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_28215);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22036);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27843);
		    DAT_ram_00a57f96 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e87920;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e87920:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  uVar2 = func_ii_6965(*(undefined4 *)(param1 + 8),0);
		  Gameplay_World_Model_ClanData__GetIsRightHandClan(uVar2,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserRatingKindDic(*(undefined4 *)(param1 + 0xc),4,0);
		  uVar2 = Core_Extensions_Dict_ClanLeagueDicExt__GetIconAssetId(uVar2,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                    (*(undefined4 *)(param1 + 0xc),StringLiteral_28215,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetBoolParameter
		                    (*(undefined4 *)(param1 + 0xc),StringLiteral_22036,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetBoolParameter
		                    (*(undefined4 *)(param1 + 0xc),StringLiteral_27843,0);
		  uVar4 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(param1 + 0x2c),0);
		  uVar2 = Core_Extensions_Dict_RegularOptionDicExt__GetBankBgAssetId(uVar4,uVar2,0);
		  *(undefined4 *)(param1 + 0x30) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		        goto code_r0x80e87a5c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e87a5c:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = Gameplay_Clans_Model_ClansModel__TryGetBuilding(*(undefined4 *)(iVar6 + 0x10),0);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  uVar7 = *(undefined4 *)(param1 + 8);
		  uVar4 = *(undefined4 *)(param1 + 0x2c);
		  uVar2 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar2,uVar7,uVar7,uVar4,0);
		  uVar8 = *(undefined4 *)(param1 + 0x20);
		  uVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		            (uVar4,uVar7,uVar7,uVar2,uVar8,0,0);
		  *(undefined4 *)(param1 + 0x24) = uVar4;
		  uVar7 = *(undefined4 *)(param1 + 8);
		  uVar4 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar2,uVar7,uVar7,uVar4,0);
		  uVar8 = *(undefined4 *)(param1 + 0x20);
		  uVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		            (uVar4,uVar7,uVar7,uVar2,uVar8,0,0);
		  *(undefined4 *)(param1 + 0x28) = uVar4;
		  uVar2 = Gameplay_Clans_Office_Model_ClanOfficeModel__ConstructArgs(param1,uVar7);
		  iVar6 = unnamed_function_1417(UI_Elements_RatingElements_SubRatings_SubRatingsListArgs_TypeInfo);
		  UI_Elements_RatingElements_SubRatings_SubRatingsList___ctor(iVar6,0);
		  *(undefined4 *)(iVar6 + 0xc) = 0;
		  *(undefined4 *)(iVar6 + 8) = uVar2;
		  *(int *)(param1 + 0x18) = iVar6;
		  return;
		}
		*/

			return null;
		}
	}
}
