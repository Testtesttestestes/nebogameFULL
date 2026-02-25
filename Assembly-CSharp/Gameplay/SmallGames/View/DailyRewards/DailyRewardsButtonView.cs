using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	public class DailyRewardsButtonView : MonoBehaviour
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BF")]
		public GameAnimatedButton GameAnimatedButton
		{
			[Token(Token = "0x6001F7C")]
			[Address(RVA = "0x70E1", Offset = "0x70E1", VA = "0x70E1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00006678 File Offset: 0x00004878
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C0")]
		public bool HasReward
		{
			[Token(Token = "0x6001F7D")]
			[Address(RVA = "0x70E2", Offset = "0x70E2", VA = "0x70E2")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F7E")]
			[Address(RVA = "0x70E3", Offset = "0x70E3", VA = "0x70E3")]
			set
			{
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x70E4", Offset = "0x70E4", VA = "0x70E4")]
		private void DetermineAnimation()
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x70E5", Offset = "0x70E5", VA = "0x70E5")]
		public DailyRewardsButtonView()
		{
		}

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _redLabel;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAnimatedButton _gameAnimatedButton;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x18")]
		private bool _hasReward;
	}
}
