using System;
using Core.Gameplay.Managers.Ad.Placements;
using Il2CppDummyDll;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Controller
{
	// Token: 0x0200122A RID: 4650
	[Token(Token = "0x200122A")]
	public interface IAdController
	{
		// Token: 0x06006E24 RID: 28196
		[Token(Token = "0x6006E24")]
		void ShowAd(uint adPlacement, uint optionId = 0U);

		// Token: 0x06006E25 RID: 28197
		[Token(Token = "0x6006E25")]
		WaitForCallBack<bool> Check(IAdPlacementData placement);
	}
}
