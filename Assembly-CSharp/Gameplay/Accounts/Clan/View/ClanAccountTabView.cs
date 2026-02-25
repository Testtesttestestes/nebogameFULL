using System;
using AssetContent;
using Gameplay.Accounts.Model.Data;
using Gameplay.SmallGames.View.DailyRewards;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.Clan.View
{
	// Token: 0x02000DEB RID: 3563
	[Token(Token = "0x2000DEB")]
	public class ClanAccountTabView : RewardsTab
	{
		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x060056F9 RID: 22265 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060056FA RID: 22266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011B8")]
		public IAccountDataDecorator Account
		{
			[Token(Token = "0x60056F9")]
			[Address(RVA = "0xA476", Offset = "0xA476", VA = "0xA476")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056FA")]
			[Address(RVA = "0xA477", Offset = "0xA477", VA = "0xA477")]
			set
			{
			}
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056FB")]
		[Address(RVA = "0x1D59", Offset = "0x1D59", VA = "0x1D59")]
		private void HandleAccountChanged()
		{
		}

		// Token: 0x060056FC RID: 22268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056FC")]
		[Address(RVA = "0xA478", Offset = "0xA478", VA = "0xA478")]
		public void UpdateAccount()
		{
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056FD")]
		[Address(RVA = "0xA479", Offset = "0xA479", VA = "0xA479")]
		public ClanAccountTabView()
		{
		}

		// Token: 0x04002F0B RID: 12043
		[Token(Token = "0x4002F0B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewPrefab;

		// Token: 0x04002F0C RID: 12044
		[Token(Token = "0x4002F0C")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameRawImage _saleBadge;

		// Token: 0x04002F0D RID: 12045
		[Token(Token = "0x4002F0D")]
		[FieldOffset(Offset = "0x60")]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002F0E RID: 12046
		[Token(Token = "0x4002F0E")]
		[FieldOffset(Offset = "0x64")]
		private IAccountDataDecorator _account;
	}
}
