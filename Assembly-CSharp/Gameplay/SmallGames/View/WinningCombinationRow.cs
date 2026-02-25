using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	public class WinningCombinationRow : MonoBehaviour
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00006660 File Offset: 0x00004860
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BD")]
		public int Index
		{
			[Token(Token = "0x6001F71")]
			[Address(RVA = "0x70D7", Offset = "0x70D7", VA = "0x70D7")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001F72")]
			[Address(RVA = "0x70D8", Offset = "0x70D8", VA = "0x70D8")]
			set
			{
			}
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x70D9", Offset = "0x70D9", VA = "0x70D9", Slot = "4")]
		protected virtual void HandleIndexChanged()
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x1CC1", Offset = "0x1CC1", VA = "0x1CC1")]
		public void Init(WinCombinationDic dic, int index = 0)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x70DA", Offset = "0x70DA", VA = "0x70DA")]
		private void SetRightIcon(GameImage slot, uint symbolId, Dictionaries dict)
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x70DB", Offset = "0x70DB", VA = "0x70DB")]
		public WinningCombinationRow()
		{
		}

		// Token: 0x04001120 RID: 4384
		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameImage _slot1;

		// Token: 0x04001121 RID: 4385
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImage _slot2;

		// Token: 0x04001122 RID: 4386
		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameImage _slot3;

		// Token: 0x04001123 RID: 4387
		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SmallGamesResourceRenderer _rewardDisplay;

		// Token: 0x04001124 RID: 4388
		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x04001125 RID: 4389
		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _lightImageTexture;

		// Token: 0x04001126 RID: 4390
		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x28")]
		protected int _index;
	}
}
