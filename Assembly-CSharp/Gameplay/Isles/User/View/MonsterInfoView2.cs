using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.RightPanel.TitledList;
using UI.Elements.RightPanel.TitledList.Elements;
using UI.Price;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1F RID: 3359
	[Token(Token = "0x2000D1F")]
	public class MonsterInfoView2 : MonoBehaviour
	{
		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A6")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x6005210")]
			[Address(RVA = "0x9FE7", Offset = "0x9FE7", VA = "0x9FE7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005211")]
			[Address(RVA = "0x9FE8", Offset = "0x9FE8", VA = "0x9FE8")]
			set
			{
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A7")]
		public ButtonWithCost AttackButton
		{
			[Token(Token = "0x6005212")]
			[Address(RVA = "0x9FE9", Offset = "0x9FE9", VA = "0x9FE9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A8")]
		public ButtonWithCost KickButton
		{
			[Token(Token = "0x6005213")]
			[Address(RVA = "0x9FEA", Offset = "0x9FEA", VA = "0x9FEA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A9")]
		public Price AttackPrice
		{
			[Token(Token = "0x6005214")]
			[Address(RVA = "0x9FEB", Offset = "0x9FEB", VA = "0x9FEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AA")]
		public Price KickPrice
		{
			[Token(Token = "0x6005215")]
			[Address(RVA = "0x9FEC", Offset = "0x9FEC", VA = "0x9FEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AB")]
		public string MonsterImageAssetId
		{
			[Token(Token = "0x6005216")]
			[Address(RVA = "0x9FED", Offset = "0x9FED", VA = "0x9FED")]
			set
			{
			}
		}

		// Token: 0x170010AC RID: 4268
		// (set) Token: 0x06005217 RID: 21015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AC")]
		public string MonsterTitle
		{
			[Token(Token = "0x6005217")]
			[Address(RVA = "0x9FEE", Offset = "0x9FEE", VA = "0x9FEE")]
			set
			{
			}
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005218")]
		[Address(RVA = "0x9FEF", Offset = "0x9FEF", VA = "0x9FEF")]
		public void SetDifficultyAndLevel(uint level, string difficulty)
		{
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AD")]
		public TitledList TitledList
		{
			[Token(Token = "0x6005219")]
			[Address(RVA = "0x9FF0", Offset = "0x9FF0", VA = "0x9FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AE")]
		public MonsterDifficultyAndLevelTitledListElement MonsterDifficultyElement
		{
			[Token(Token = "0x600521A")]
			[Address(RVA = "0x9FF1", Offset = "0x9FF1", VA = "0x9FF1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x0600521B RID: 21019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AF")]
		private RewardsTitledListElement RewardsElement
		{
			[Token(Token = "0x600521B")]
			[Address(RVA = "0x9FF2", Offset = "0x9FF2", VA = "0x9FF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600521C")]
		[Address(RVA = "0x9FF3", Offset = "0x9FF3", VA = "0x9FF3")]
		public MonsterInfoView2()
		{
		}

		// Token: 0x04002C9F RID: 11423
		[Token(Token = "0x4002C9F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002CA0 RID: 11424
		[Token(Token = "0x4002CA0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _monsterImage;

		// Token: 0x04002CA1 RID: 11425
		[Token(Token = "0x4002CA1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ButtonWithCost _attackButton;

		// Token: 0x04002CA2 RID: 11426
		[Token(Token = "0x4002CA2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _kickButton;

		// Token: 0x04002CA3 RID: 11427
		[Token(Token = "0x4002CA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitledList _titledList;

		// Token: 0x04002CA4 RID: 11428
		[Token(Token = "0x4002CA4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _disableDifficultyLabel;

		// Token: 0x04002CA5 RID: 11429
		[Token(Token = "0x4002CA5")]
		[FieldOffset(Offset = "0x28")]
		private MonsterDifficultyAndLevelTitledListElement _monsterDifficultyElement;

		// Token: 0x04002CA6 RID: 11430
		[Token(Token = "0x4002CA6")]
		[FieldOffset(Offset = "0x2C")]
		private RewardsTitledListElement _rewardsElement;
	}
}
