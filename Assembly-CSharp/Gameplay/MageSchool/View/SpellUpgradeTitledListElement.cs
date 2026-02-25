using System;
using System.Collections.Generic;
using Core.Data.Balance;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.ProgressBars;
using UI.Elements.RightPanel.TitledList;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.MageSchool.View
{
	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	public class SpellUpgradeTitledListElement : BaseTitledListElement<SpellUpgradeTitledListElementArgs>, IDiscountTarget
	{
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000741")]
		public Button StartLearnFirstButton
		{
			[Token(Token = "0x60026C9")]
			[Address(RVA = "0x77FE", Offset = "0x77FE", VA = "0x77FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000742")]
		public Button StartLearnButton
		{
			[Token(Token = "0x60026CA")]
			[Address(RVA = "0x77FF", Offset = "0x77FF", VA = "0x77FF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000743")]
		public ButtonWithCost BoostButton
		{
			[Token(Token = "0x60026CB")]
			[Address(RVA = "0x7800", Offset = "0x7800", VA = "0x7800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000744")]
		public Button CancelButton
		{
			[Token(Token = "0x60026CC")]
			[Address(RVA = "0x7801", Offset = "0x7801", VA = "0x7801")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x7802", Offset = "0x7802", VA = "0x7802", Slot = "6")]
		protected override void OnInit(SpellUpgradeTitledListElementArgs args)
		{
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x7803", Offset = "0x7803", VA = "0x7803")]
		private void OnDestroy()
		{
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x7804", Offset = "0x7804", VA = "0x7804")]
		public void UpdateSpell(SchoolSpellData spellData, IBalanceSource balance)
		{
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0x7805", Offset = "0x7805", VA = "0x7805")]
		private void UpdateBoostPrice(SchoolSpellData schoolSpellData, IBalanceSource balance)
		{
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000745")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x60026D1")]
			[Address(RVA = "0x7806", Offset = "0x7806", VA = "0x7806", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x7807", Offset = "0x7807", VA = "0x7807", Slot = "8")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x7808", Offset = "0x7808", VA = "0x7808")]
		public SpellUpgradeTitledListElement()
		{
		}

		// Token: 0x0400152B RID: 5419
		[Token(Token = "0x400152B")]
		private const string SPELL_UPGRADE_TO_LEVEL = "SCHOOL/SPELL/UPGRADE_TO_LEVEL";

		// Token: 0x0400152C RID: 5420
		[Token(Token = "0x400152C")]
		private const string SPELL_UPGRADE_TIME = "SCHOOL/SPELL/UPGRADE_TIME";

		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		private const string LEVEL_TAG = "value";

		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400152F RID: 5423
		[Token(Token = "0x400152F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001530 RID: 5424
		[Token(Token = "0x4001530")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;

		// Token: 0x04001532 RID: 5426
		[Token(Token = "0x4001532")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressBarWithTimer _progressBar;

		// Token: 0x04001533 RID: 5427
		[Token(Token = "0x4001533")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _startLearnFirstButton;

		// Token: 0x04001534 RID: 5428
		[Token(Token = "0x4001534")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _startLearnButton;

		// Token: 0x04001535 RID: 5429
		[Token(Token = "0x4001535")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ButtonWithCost _boostButton;

		// Token: 0x04001536 RID: 5430
		[Token(Token = "0x4001536")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x04001537 RID: 5431
		[Token(Token = "0x4001537")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _durationUpgrade;

		// Token: 0x04001538 RID: 5432
		[Token(Token = "0x4001538")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _normalView;

		// Token: 0x04001539 RID: 5433
		[Token(Token = "0x4001539")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private RectTransform _maxLevelView;

		// Token: 0x0400153A RID: 5434
		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DiscountGroup _discountGroup;
	}
}
