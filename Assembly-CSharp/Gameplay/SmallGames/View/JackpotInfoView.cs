using System;
using Gameplay.Rating.View;
using Gameplay.SmallGames.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000513 RID: 1299
	[Token(Token = "0x2000513")]
	public class JackpotInfoView : MonoBehaviour
	{
		// Token: 0x06001EF6 RID: 7926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x705D", Offset = "0x705D", VA = "0x705D")]
		public void SetJackpotInfo(in SmallGamesModel.JackpotInfo jackpot, Dictionaries dict)
		{
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x705E", Offset = "0x705E", VA = "0x705E")]
		public JackpotInfoView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_View_JackpotInfoView___ctor
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 *param4_00;
		  
		  if (param2 == 1) {
		    param4_00 = (undefined4 *)(param1 + 0x10);
		  }
		  else {
		    if (param2 != 2) {
		      return;
		    }
		    param4_00 = (undefined4 *)(param1 + 0x14);
		  }
		  Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator__UpdateView
		            (*param4_00,param3,param4,param4_00);
		  return;
		}
		*/

		}

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _winInfo;

		// Token: 0x040010C2 RID: 4290
		[Token(Token = "0x40010C2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SmallGamesResourceRenderer _resourceRenderer;

		// Token: 0x040010C3 RID: 4291
		[Token(Token = "0x40010C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserView _userView;
	}
}
