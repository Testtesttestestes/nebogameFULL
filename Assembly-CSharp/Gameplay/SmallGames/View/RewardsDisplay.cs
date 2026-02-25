using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	public class RewardsDisplay : MonoBehaviour
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A2")]
		public Button TakeButton
		{
			[Token(Token = "0x6001F08")]
			[Address(RVA = "0x706F", Offset = "0x706F", VA = "0x706F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A3")]
		public CounterAutoHide RedCounter
		{
			[Token(Token = "0x6001F09")]
			[Address(RVA = "0x7070", Offset = "0x7070", VA = "0x7070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x7071", Offset = "0x7071", VA = "0x7071")]
		public void DisplayRewards(IEnumerable<RewardInfo> resources)
		{
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x7072", Offset = "0x7072", VA = "0x7072")]
		public RewardsDisplay()
		{
		}

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SmallGamesResourceRenderer _resourceRendererPrefab;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _redCounter;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x20")]
		private List<SmallGamesResourceRenderer> _spawnedLists;
	}
}
