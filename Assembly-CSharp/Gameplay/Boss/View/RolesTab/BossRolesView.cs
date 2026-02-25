using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Model;
using Gameplay.School.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buildings;
using UnityEngine;

namespace Gameplay.Boss.View.RolesTab
{
	// Token: 0x02000B5A RID: 2906
	[Token(Token = "0x2000B5A")]
	public class BossRolesView : AbstractBossWindowView<BossRolesView, BossRolesViewMediator>
	{
		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06004650 RID: 18000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDC")]
		public BossPossibleEmptyWindowStateController StateController
		{
			[Token(Token = "0x6004650")]
			[Address(RVA = "0x94E9", Offset = "0x94E9", VA = "0x94E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDD")]
		public BossRoleSpellDescription SpellDescription
		{
			[Token(Token = "0x6004651")]
			[Address(RVA = "0x94EA", Offset = "0x94EA", VA = "0x94EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06004652 RID: 18002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDE")]
		public SpellTitle SpellTitle
		{
			[Token(Token = "0x6004652")]
			[Address(RVA = "0x94EB", Offset = "0x94EB", VA = "0x94EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDF")]
		public TextMeshProUGUI CultTitle
		{
			[Token(Token = "0x6004653")]
			[Address(RVA = "0x94EC", Offset = "0x94EC", VA = "0x94EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DE0")]
		public GameRawImage CultIcon
		{
			[Token(Token = "0x6004654")]
			[Address(RVA = "0x94ED", Offset = "0x94ED", VA = "0x94ED")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DE1")]
		public BossInfo.BossCultSpellData SelectedItem
		{
			[Token(Token = "0x6004655")]
			[Address(RVA = "0x94EE", Offset = "0x94EE", VA = "0x94EE")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B3 RID: 435
		// (add) Token: 0x06004656 RID: 18006 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004657 RID: 18007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B3")]
		public event Action<BossInfo.BossCultSpellData> SelectedEvent
		{
			[Token(Token = "0x6004656")]
			[Address(RVA = "0x94EF", Offset = "0x94EF", VA = "0x94EF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004657")]
			[Address(RVA = "0x94F0", Offset = "0x94F0", VA = "0x94F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004658")]
		[Address(RVA = "0x94F1", Offset = "0x94F1", VA = "0x94F1", Slot = "5")]
		protected override BossRolesViewMediator CreateMediator()
		{
			return null;
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600465A RID: 18010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE2")]
		public List<BossInfo.BossCultSpellData> Spells
		{
			[Token(Token = "0x6004659")]
			[Address(RVA = "0x94F2", Offset = "0x94F2", VA = "0x94F2")]
			get
			{
				return null;
			}
			[Token(Token = "0x600465A")]
			[Address(RVA = "0x94F3", Offset = "0x94F3", VA = "0x94F3")]
			set
			{
			}
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465B")]
		[Address(RVA = "0x94F4", Offset = "0x94F4", VA = "0x94F4")]
		private void OnSpellClickedEvent(SpellItemArgs arg0)
		{
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465C")]
		[Address(RVA = "0x1B97", Offset = "0x1B97", VA = "0x1B97")]
		public void Select(BossInfo.BossCultSpellData selectedItem)
		{
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465D")]
		[Address(RVA = "0x94F5", Offset = "0x94F5", VA = "0x94F5")]
		public BossRolesView()
		{
		}

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _cultTitle;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameRawImage _cultIcon;

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpellTitle _spellTitle;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BossRoleSpellDescription _spellDescription;

		// Token: 0x0400267B RID: 9851
		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BossPossibleEmptyWindowStateController _stateController;

		// Token: 0x0400267C RID: 9852
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SpellItem _spellItemPrefab;

		// Token: 0x0400267D RID: 9853
		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x40")]
		private List<SpellItem> _spellItems;

		// Token: 0x0400267E RID: 9854
		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x44")]
		private BossInfo.BossCultSpellData _selectedItem;

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x4C")]
		private List<BossInfo.BossCultSpellData> _spells;
	}
}
