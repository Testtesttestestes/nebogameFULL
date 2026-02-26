using System;
using Core.Data;
using Gameplay.Isles.Base;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Consts;

namespace Gameplay.Isles.Clan
{
	// Token: 0x02000CEF RID: 3311
	[Token(Token = "0x2000CEF")]
	public class ClanIsle : AbstractIsle<Gameplay.Isles.Clan.Events.ClanIsleEvents, ClanIsleModel, ClanIsleController, ClanBuildingTypes>
	{
		// Token: 0x06005094 RID: 20628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005094")]
		[Address(RVA = "0x9EA3", Offset = "0x9EA3", VA = "0x9EA3")]
		public ClanIsle(ClanData clanData, UserData loggedUser, ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInformation)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Clan_ClanIsle___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a58ca9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Controller__
		              );
		    DAT_ram_00a58ca9 = '\x01';
		  }
		  param2_00 = Gameplay_World_Model_ClanData__set_ClanCultDic(param2,0);
		  Facebook_Unity_Subscription__get_PeriodStartTime
		            (param1,param2_00,
		             Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes___ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = param3;
		  *(undefined4 *)(param1 + 0x24) = param2;
		  Gameplay_Isles_Clan_ClanIsle___ctor(param1,param1);
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Clan_ClanIsle___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a58ca9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Controller__
		              );
		    DAT_ram_00a58ca9 = '\x01';
		  }
		  param2_00 = Gameplay_World_Model_ClanData__set_ClanCultDic(param2,0);
		  Facebook_Unity_Subscription__get_PeriodStartTime
		            (param1,param2_00,
		             Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes___ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = param3;
		  *(undefined4 *)(param1 + 0x24) = param2;
		  Gameplay_Isles_Clan_ClanIsle___ctor(param1,param1);
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x06005095 RID: 20629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005095")]
		[Address(RVA = "0x9EA4", Offset = "0x9EA4", VA = "0x9EA4")]
		public ClanIsle(ClanData clanData, UserData loggedUser)
		{
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005096")]
		[Address(RVA = "0x9EA5", Offset = "0x9EA5", VA = "0x9EA5")]
		protected void CreateMvc()
		{
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x1700104A")]
		public override LocationTypes LocationType
		{
			[Token(Token = "0x6005097")]
			[Address(RVA = "0x9EA6", Offset = "0x9EA6", VA = "0x9EA6", Slot = "10")]
			get
			{
				return LocationTypes.UnknownLocationType;
			}
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x6005098")]
		[Address(RVA = "0x9EA7", Offset = "0x9EA7", VA = "0x9EA7", Slot = "11")]
		public override bool TryOpenBuildingByType(uint type)
		{
		/* --- GHIDRA: TryOpenBuildingByType ---
		void Gameplay_Isles_Clan_ClanIsle__TryOpenBuildingByType(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58cac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17939);
		    DAT_ram_00a58cac = '\x01';
		  }
		  local_8 = *(undefined8 *)(param1 + 0x18);
		  uVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_17939,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum____ctor
		            (param1,
		             Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__Dispose__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005099")]
		[Address(RVA = "0x9EA8", Offset = "0x9EA8", VA = "0x9EA8", Slot = "12")]
		public override void Dispose()
		{
		}

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		[FieldOffset(Offset = "0x24")]
		private readonly ClanData _clanData;

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		[FieldOffset(Offset = "0x28")]
		private readonly UserData _loggedUser;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LocationType ---
		uint Gameplay_Isles_Clan_ClanIsle__get_LocationType(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  uint uVar7;
		  undefined4 local_4;
		  
		  iVar6 = 0;
		  iVar1 = 0;
		  if (DAT_ram_00a58cab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow_GolemInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_MagicTowerWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GolemInfoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_MagicTowerWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ZigguratWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Ziggurat_View_ZigguratWindow_ZigguratWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12591);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12588);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12587);
		    DAT_ram_00a58cab = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x24),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                    );
		  if (iVar2 != 0) {
		    if (param2 == 1) {
		      uVar4 = System_Uri___ctor(0);
		      uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar4,0);
		      uVar5 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_Ziggurat_View_ZigguratWindow_ZigguratWindowArgs_TypeInfo
		                        );
		      Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow___ctor(uVar5,param1,1,0);
		      iVar6 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                        (uVar4,StringLiteral_12588,uVar5,
		                         Method_UI_Windows_PopupController_Show_ZigguratWindow___);
		    }
		    else {
		      iVar6 = *(int *)(param1 + 0x10);
		      if (DAT_ram_00a58cec == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                  );
		        DAT_ram_00a58cec = '\x01';
		      }
		      iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                        (*(undefined4 *)(iVar6 + 0x24),param2,&local_4,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                        );
		      iVar6 = iVar1;
		      if ((iVar2 != 0) &&
		         (iVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(local_4,0),
		         iVar1 != 0)) {
		        if (param2 == 2) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar6 = *param1_00;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            uVar7 = 0;
		            do {
		              if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		                puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 +
		                                 0x230);
		                goto code_r0x80f96909;
		              }
		              uVar7 = uVar7 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		          }
		          puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f96909:
		          iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		          iVar6 = 0;
		          if (*(longlong *)(*(int *)(iVar1 + 0x10) + 0x10) == *(longlong *)(param1 + 0x18)) {
		            uVar4 = System_Uri___ctor(0);
		            uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar4,0);
		            uVar5 = unnamed_function_1417
		                              (
		                              Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow_MagicTowerWindowArgs_TypeInfo
		                              );
		            Gameplay_Clans_Buildings_MagicTower_View_MagicTowerWindow___ctor(uVar5,param1,2,0);
		            iVar6 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                              (uVar4,StringLiteral_12587,uVar5,
		                               Method_UI_Windows_PopupController_Show_MagicTowerWindow___);
		          }
		        }
		        else if (param2 == 3) {
		          uVar4 = System_Uri___ctor(0);
		          uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar4,0);
		          iVar6 = unnamed_function_1417
		                            (
		                            Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow_GolemInfoWindowArgs_TypeInfo
		                            );
		          Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar6,0);
		          *(int *)(iVar6 + 0x18) = param1;
		          iVar6 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                            (uVar4,StringLiteral_12591,iVar6,
		                             Method_UI_Windows_PopupController_Show_GolemInfoWindow___);
		        }
		      }
		    }
		  }
		  return (uint)(iVar6 != 0);
		}
		*/

}
