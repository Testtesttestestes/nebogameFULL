using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab
{
	// Token: 0x02000A1B RID: 2587
	[Token(Token = "0x2000A1B")]
	public class ClanWarsHistoryInfoBox : MonoBehaviour
	{
		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C36")]
		public Button WarButton
		{
			[Token(Token = "0x6003D79")]
			[Address(RVA = "0x8C38", Offset = "0x8C38", VA = "0x8C38")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x8C39", Offset = "0x8C39", VA = "0x8C39")]
		public void Init(string honorAssetId)
		{
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x8C3A", Offset = "0x8C3A", VA = "0x8C3A")]
		public void UpdateHistory(ProtoGetWarsHistoryAns.Types.WarHistoryRecord history, ClanWarResultDic result)
		{
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x8C3B", Offset = "0x8C3B", VA = "0x8C3B")]
		public ClanWarsHistoryInfoBox()
		{
		}

		// Token: 0x04002253 RID: 8787
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002254 RID: 8788
		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002255 RID: 8789
		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002256 RID: 8790
		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TitleIconValueBackground _enemyHonor;

		// Token: 0x04002257 RID: 8791
		[Token(Token = "0x4002257")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitleIconValueBackground _honorDelta;

		// Token: 0x04002258 RID: 8792
		[Token(Token = "0x4002258")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _zigguratLevel;

		// Token: 0x04002259 RID: 8793
		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TitleRowView _titleRow;

		// Token: 0x0400225A RID: 8794
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _warButton;
	}
}
