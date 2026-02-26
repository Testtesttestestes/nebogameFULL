using System;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Rating.View
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	public class UserInCommonRatingsViewsHolder : ItemViewsHolder<UserInRatingListElement>
	{
		// Token: 0x06002193 RID: 8595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002193")]
		[Address(RVA = "0x72F2", Offset = "0x72F2", VA = "0x72F2", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Rating_View_UserInCommonRatingsViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58024 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_UserInRatingListElement___ctor__);
		    DAT_ram_00a58024 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002194")]
		[Address(RVA = "0x72F3", Offset = "0x72F3", VA = "0x72F3")]
		public UserInCommonRatingsViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_UserInCommonRatingsViewsHolder___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a58025 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CultInRatingListElement_CultInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a58025 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = System_Collections_Generic_Dictionary_object__object____ctor
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x2c);
		  uVar3 = *(uint *)(*(int *)(param1 + 0x18) + 0x20);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar2 = UI_SimpleIconValue__set_IconAssetId((double)uVar3,StringLiteral_28780,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = func_ii_4443(*(int *)(param1 + 0x18) + 0x24,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  AssetContent_GameImage__get_AssetId(uVar2,uVar1,0);
		  return;
		}
		*/

		}
	}
}
