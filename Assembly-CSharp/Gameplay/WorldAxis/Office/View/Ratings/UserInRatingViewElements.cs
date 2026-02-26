using System;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	[Serializable]
	public class UserInRatingViewElements : UserBasicViewElements
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x6425", Offset = "0x6425", VA = "0x6425")]
		public void AssignAssets(UserData userData, string place)
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x6426", Offset = "0x6426", VA = "0x6426")]
		public UserInRatingViewElements()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserInRatingViewElements___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  Gameplay_Rating_View_UserView__get_UserData(*(undefined4 *)(param1 + 8),param2,0);
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                    (*(undefined4 *)(param2 + 0x4c),0);
		  AssetContent_GameImage__get_AssetId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _place;
	}
}
