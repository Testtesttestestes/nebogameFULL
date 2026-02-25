using System;
using Gameplay.Combat.View.Spells;
using Il2CppDummyDll;
using Protocol.Combat;
using UI.Price;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.VortexCombat.View.Spells
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public class VortexCombatSpellButton : CombatSpellButton
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x67A6", Offset = "0x67A6", VA = "0x67A6", Slot = "18")]
		public override BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x67A7", Offset = "0x67A7", VA = "0x67A7", Slot = "12")]
		protected override void ValidateManaPrice()
		{
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x67A8", Offset = "0x67A8", VA = "0x67A8", Slot = "9")]
		protected override void DisplayPrice()
		{
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x67A9", Offset = "0x67A9", VA = "0x67A9", Slot = "10")]
		protected override PriceItemRenderer CreateManaPrice()
		{
			return null;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x67AA", Offset = "0x67AA", VA = "0x67AA")]
		public VortexCombatSpellButton()
		{
		}

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private VortexCombatSpellButton.Config[] _configs;

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x60")]
		private PriceItemRenderer _manaBoostPriceRender;

		// Token: 0x020003AB RID: 939
		[Token(Token = "0x20003AB")]
		[Serializable]
		public class Config
		{
			// Token: 0x1700039D RID: 925
			// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000052E0 File Offset: 0x000034E0
			[Token(Token = "0x1700039D")]
			public StonesTypes Stone
			{
				[Token(Token = "0x60015E9")]
				[Address(RVA = "0x67AB", Offset = "0x67AB", VA = "0x67AB")]
				get
				{
					return StonesTypes.Empty;
				}
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x060015EA RID: 5610 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700039E")]
			public Sprite Icon
			{
				[Token(Token = "0x60015EA")]
				[Address(RVA = "0x67AC", Offset = "0x67AC", VA = "0x67AC")]
				get
				{
					return null;
				}
			}

			// Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015EB")]
			[Address(RVA = "0x67AD", Offset = "0x67AD", VA = "0x67AD")]
			public Config()
			{
			}

			// Token: 0x04000B9D RID: 2973
			[Token(Token = "0x4000B9D")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private StonesTypes _stone;

			// Token: 0x04000B9E RID: 2974
			[Token(Token = "0x4000B9E")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Sprite _icon;
		}
	}
}
