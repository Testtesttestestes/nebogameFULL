using System;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Clan.Control;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Gameplay.Accounts.View.Accounts;
using Gameplay.SmallGames.View.DailyRewards;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.Clan.View
{
	// Token: 0x02000DEC RID: 3564
	[Token(Token = "0x2000DEC")]
	public class ClanAccountView : AbstractAccountView
	{
		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060056FE RID: 22270 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011B9")]
		public OptionBuyButtonItem OptionViewPrefab
		{
			[Token(Token = "0x60056FE")]
			[Address(RVA = "0xA47A", Offset = "0xA47A", VA = "0xA47A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BA")]
		public SimpleIconValue BonusPrefab
		{
			[Token(Token = "0x60056FF")]
			[Address(RVA = "0xA47B", Offset = "0xA47B", VA = "0xA47B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BB")]
		public Transform OptionsContainer
		{
			[Token(Token = "0x6005700")]
			[Address(RVA = "0xA47C", Offset = "0xA47C", VA = "0xA47C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BC")]
		public TextMeshProUGUI ActiveAccountStatusField
		{
			[Token(Token = "0x6005701")]
			[Address(RVA = "0xA47D", Offset = "0xA47D", VA = "0xA47D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06005702 RID: 22274 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BD")]
		public Transform Bonuses
		{
			[Token(Token = "0x6005702")]
			[Address(RVA = "0xA47E", Offset = "0xA47E", VA = "0xA47E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BE")]
		public ClanAccountTabView[] Tabs
		{
			[Token(Token = "0x6005703")]
			[Address(RVA = "0xA47F", Offset = "0xA47F", VA = "0xA47F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06005704 RID: 22276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BF")]
		public TextMeshProUGUI ContentTitle
		{
			[Token(Token = "0x6005704")]
			[Address(RVA = "0xA480", Offset = "0xA480", VA = "0xA480")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000206 RID: 518
		// (add) Token: 0x06005705 RID: 22277 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005706 RID: 22278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000206")]
		public event Action<ClanAccountTabView> TabSelectedEvent
		{
			[Token(Token = "0x6005705")]
			[Address(RVA = "0xA481", Offset = "0xA481", VA = "0xA481")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005706")]
			[Address(RVA = "0xA482", Offset = "0xA482", VA = "0xA482")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005707")]
		[Address(RVA = "0xA483", Offset = "0xA483", VA = "0xA483", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005708")]
		[Address(RVA = "0xA484", Offset = "0xA484", VA = "0xA484", Slot = "7")]
		public override void Init(AccountsController controller, IAccountDataDecorator data)
		{
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005709")]
		[Address(RVA = "0xA485", Offset = "0xA485", VA = "0xA485")]
		public RewardsTab AddTab(int index, IAccountDataDecorator account)
		{
			return null;
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570A")]
		[Address(RVA = "0xA486", Offset = "0xA486", VA = "0xA486")]
		public void SelectTab(int index)
		{
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570B")]
		[Address(RVA = "0xA487", Offset = "0xA487", VA = "0xA487")]
		private void InvokeSelectedEvent(ClanAccountTabView tab)
		{
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570C")]
		[Address(RVA = "0xA488", Offset = "0xA488", VA = "0xA488", Slot = "8")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570D")]
		[Address(RVA = "0xA489", Offset = "0xA489", VA = "0xA489")]
		public ClanAccountView()
		{
		}

		// Token: 0x04002F0F RID: 12047
		[Token(Token = "0x4002F0F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _contentTitle;

		// Token: 0x04002F10 RID: 12048
		[Token(Token = "0x4002F10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _activeTabsParent;

		// Token: 0x04002F11 RID: 12049
		[Token(Token = "0x4002F11")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RectTransform _inactiveTabsParent;

		// Token: 0x04002F12 RID: 12050
		[Token(Token = "0x4002F12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bonuses;

		// Token: 0x04002F13 RID: 12051
		[Token(Token = "0x4002F13")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _activeAccountStatusField;

		// Token: 0x04002F14 RID: 12052
		[Token(Token = "0x4002F14")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClanAccountTabView[] _tabs;

		// Token: 0x04002F15 RID: 12053
		[Token(Token = "0x4002F15")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _optionsContainer;

		// Token: 0x04002F16 RID: 12054
		[Token(Token = "0x4002F16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleIconValue _bonusPrefab;

		// Token: 0x04002F17 RID: 12055
		[Token(Token = "0x4002F17")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OptionBuyButtonItem _optionViewPrefab;

		// Token: 0x04002F19 RID: 12057
		[Token(Token = "0x4002F19")]
		[FieldOffset(Offset = "0x54")]
		private ClanAccountTabView _selectedTab;

		// Token: 0x04002F1A RID: 12058
		[Token(Token = "0x4002F1A")]
		[FieldOffset(Offset = "0x58")]
		private ClanAccountViewMediator _mediator;

		// Token: 0x04002F1B RID: 12059
		[Token(Token = "0x4002F1B")]
		[FieldOffset(Offset = "0x5C")]
		private ClanAccountController _controller;
	}
}
