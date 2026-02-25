using System;
using AssetContent;
using Core.Data;
using Gameplay.Clans.Buildings.Golem.Controller;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Isles.Clan;
using Gameplay.UserInfo.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC3 RID: 2755
	[Token(Token = "0x2000AC3")]
	public class GolemInfoWindow : ClosableBaseWindow<GolemInfoWindow.GolemInfoWindowArgs>
	{
		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600426C RID: 17004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D0F")]
		public override string WindowId
		{
			[Token(Token = "0x600426C")]
			[Address(RVA = "0x9120", Offset = "0x9120", VA = "0x9120", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D10")]
		public IndexButtonBasic WarStatusButton
		{
			[Token(Token = "0x600426D")]
			[Address(RVA = "0x9121", Offset = "0x9121", VA = "0x9121")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D11")]
		public IndexButtonBasic UpgradeButton
		{
			[Token(Token = "0x600426E")]
			[Address(RVA = "0x9122", Offset = "0x9122", VA = "0x9122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D12")]
		public IndexButtonBasic ChestButton
		{
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x9123", Offset = "0x9123", VA = "0x9123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D13")]
		public IndexButtonBasic ArmoryButton
		{
			[Token(Token = "0x6004270")]
			[Address(RVA = "0x9124", Offset = "0x9124", VA = "0x9124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D14")]
		public Button InfoButton
		{
			[Token(Token = "0x6004271")]
			[Address(RVA = "0x9125", Offset = "0x9125", VA = "0x9125")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D15")]
		public SkillsInfoView SkillsInfoBox
		{
			[Token(Token = "0x6004272")]
			[Address(RVA = "0x9126", Offset = "0x9126", VA = "0x9126")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D16")]
		public GolemEquipmentView GolemEquipmentView
		{
			[Token(Token = "0x6004273")]
			[Address(RVA = "0x9127", Offset = "0x9127", VA = "0x9127")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004274")]
		[Address(RVA = "0x9128", Offset = "0x9128", VA = "0x9128")]
		public void Init(UserData golemUserData, BaseBuildingData golemBuildingData)
		{
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x9129", Offset = "0x9129", VA = "0x9129", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x912A", Offset = "0x912A", VA = "0x912A", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004277")]
		[Address(RVA = "0x912B", Offset = "0x912B", VA = "0x912B")]
		private void SetupMVC()
		{
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x912C", Offset = "0x912C", VA = "0x912C")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x912D", Offset = "0x912D", VA = "0x912D")]
		public GolemInfoWindow()
		{
		}

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/GolemInfoWindow";

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GolemEquipmentView _equipmentView;

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CombatPlayerLevelView _levelView;

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CultWhitBackground _cultView;

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SkillsInfoView _skillsInfoBox;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private IndexButtonBasic _warStatusButton;

		// Token: 0x040024A4 RID: 9380
		[Token(Token = "0x40024A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private IndexButtonBasic _upgradeButton;

		// Token: 0x040024A5 RID: 9381
		[Token(Token = "0x40024A5")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private IndexButtonBasic _chestButton;

		// Token: 0x040024A6 RID: 9382
		[Token(Token = "0x40024A6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private IndexButtonBasic _armory;

		// Token: 0x040024A7 RID: 9383
		[Token(Token = "0x40024A7")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x040024A8 RID: 9384
		[Token(Token = "0x40024A8")]
		[FieldOffset(Offset = "0x68")]
		private GolemInfoViewMediator _mediator;

		// Token: 0x040024A9 RID: 9385
		[Token(Token = "0x40024A9")]
		[FieldOffset(Offset = "0x6C")]
		private GolemController _controller;

		// Token: 0x040024AA RID: 9386
		[Token(Token = "0x40024AA")]
		[FieldOffset(Offset = "0x70")]
		private GolemModel _model;

		// Token: 0x040024AB RID: 9387
		[Token(Token = "0x40024AB")]
		[FieldOffset(Offset = "0x74")]
		private GolemEvents _events;

		// Token: 0x02000AC4 RID: 2756
		[Token(Token = "0x2000AC4")]
		public class GolemInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600427A RID: 17018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600427A")]
			[Address(RVA = "0x912E", Offset = "0x912E", VA = "0x912E")]
			public GolemInfoWindowArgs()
			{
			}

			// Token: 0x040024AC RID: 9388
			[Token(Token = "0x40024AC")]
			[FieldOffset(Offset = "0x18")]
			public ClanIsle ClanIsle;
		}
	}
}
