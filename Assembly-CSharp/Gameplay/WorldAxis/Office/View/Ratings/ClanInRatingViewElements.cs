using System;
using AssetContent;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2000309")]
	[Serializable]
	public class ClanInRatingViewElements
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x641D", Offset = "0x641D", VA = "0x641D")]
		public void AssignAssets(string title, string place, string clanCultIconAssetId, string leagueBannerAssetId, string leagueIconAssetId)
		{
		/* --- GHIDRA: AssignAssets ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanInRatingViewElements__AssignAssets
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 param2_01;
		  undefined4 param2_02;
		  int iVar2;
		  undefined4 param2_03;
		  
		  param2_03 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 0x18);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0xdc));
		  if ((*(byte *)(*(int *)(param2 + 0x1c) + 0x20) & 1) == 0) {
		    param2_00 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                          (*(undefined4 *)(param2 + 8),0);
		  }
		  else {
		    param2_00 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId
		                          (*(undefined4 *)(param2 + 0x10),0);
		  }
		  param2_01 = Core_Extensions_Dict_ClanLeagueDicExt__GetDescription
		                        (*(undefined4 *)(param2 + 0x20),0);
		  param2_02 = Core_Extensions_Dict_ClanLeagueDicExt__GetBanner2AssetId
		                        (*(undefined4 *)(param2 + 0x20),0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 8),param2_03,0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0xc),uVar1,0);
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x14),param2_01,0);
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x18),param2_02,0);
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  iVar2 = Gameplay_World_Model_ClanData__set_ClanLeagueDic(param2,param2);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(iVar2 + 0xc) != 0),0);
		  return;
		}
		*/

		/* --- GHIDRA: AssignAssets ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanInRatingViewElements__AssignAssets
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 param2_01;
		  undefined4 param2_02;
		  int iVar2;
		  undefined4 param2_03;
		  
		  param2_03 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 0x18);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd8) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0xdc));
		  if ((*(byte *)(*(int *)(param2 + 0x1c) + 0x20) & 1) == 0) {
		    param2_00 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                          (*(undefined4 *)(param2 + 8),0);
		  }
		  else {
		    param2_00 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId
		                          (*(undefined4 *)(param2 + 0x10),0);
		  }
		  param2_01 = Core_Extensions_Dict_ClanLeagueDicExt__GetDescription
		                        (*(undefined4 *)(param2 + 0x20),0);
		  param2_02 = Core_Extensions_Dict_ClanLeagueDicExt__GetBanner2AssetId
		                        (*(undefined4 *)(param2 + 0x20),0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 8),param2_03,0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0xc),uVar1,0);
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x14),param2_01,0);
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x18),param2_02,0);
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  iVar2 = Gameplay_World_Model_ClanData__set_ClanLeagueDic(param2,param2);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(iVar2 + 0xc) != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x641E", Offset = "0x641E", VA = "0x641E")]
		public void AssignAssets(ClanData clanData, string place)
		{
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x641F", Offset = "0x641F", VA = "0x641F")]
		public ClanInRatingViewElements()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_ClanInRatingViewElements___ctor
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  
		  if (*(int *)(*(int *)(param1 + 0xc) + 0xc) < param2) {
		    puVar1 = (undefined4 *)(param1 + 0x14);
		    if (param3 == 0) {
		      puVar1 = (undefined4 *)(param1 + 0x10);
		    }
		  }
		  else {
		    puVar1 = (undefined4 *)(param2 * 4 + *(int *)(param1 + 0xc) + 0xc);
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 8),*puVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private TextMeshProUGUI _place;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameImage _cultIcon;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImage _leagueBanner;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameImage _leagueIcon;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameObject _restrictionsIndicator;
	}
}
