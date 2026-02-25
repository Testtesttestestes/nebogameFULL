using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Gameplay.Ad.BattleBonusesAd.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DBC RID: 3516
	[Token(Token = "0x2000DBC")]
	public class BattleBonusesAdWindow : BaseDialogWindow<BattleBonusesAdWindow.BattleBonusesAdWindowArgs>
	{
		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001171")]
		public override string WindowId
		{
			[Token(Token = "0x60055CC")]
			[Address(RVA = "0xA36C", Offset = "0xA36C", VA = "0xA36C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060055CD RID: 21965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001172")]
		public Button WatchButton
		{
			[Token(Token = "0x60055CD")]
			[Address(RVA = "0xA36D", Offset = "0xA36D", VA = "0xA36D")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CE")]
		[Address(RVA = "0xA36E", Offset = "0xA36E", VA = "0xA36E", Slot = "22")]
		protected override void OnShow(BattleBonusesAdWindow.BattleBonusesAdWindowArgs args)
		{
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CF")]
		[Address(RVA = "0xA36F", Offset = "0xA36F", VA = "0xA36F", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0xA370", Offset = "0xA370", VA = "0xA370", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D1")]
		[Address(RVA = "0xA371", Offset = "0xA371", VA = "0xA371")]
		public BattleBonusesAdWindow()
		{
		}

		// Token: 0x04002E7B RID: 11899
		[Token(Token = "0x4002E7B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Ad/BattleBonusesAdWindow";

		// Token: 0x04002E7C RID: 11900
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BattleBonusesBonusRenderer _battleBonusesBonusRenderer;

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0x58")]
		private BattleBonusesAdWindowMediator _mediator;

		// Token: 0x02000DBD RID: 3517
		[Token(Token = "0x2000DBD")]
		public class BattleBonusesAdWindowArgs : BaseDialogWindow<BattleBonusesAdWindow.BattleBonusesAdWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060055D2 RID: 21970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60055D2")]
			[Address(RVA = "0xA372", Offset = "0xA372", VA = "0xA372")]
			public BattleBonusesAdWindowArgs()
			{
			}

			// Token: 0x04002E7F RID: 11903
			[Token(Token = "0x4002E7F")]
			[FieldOffset(Offset = "0x2C")]
			public MedalData BonusMedalData;

			// Token: 0x04002E80 RID: 11904
			[Token(Token = "0x4002E80")]
			[FieldOffset(Offset = "0x30")]
			public BattleBonusesAdController Controller;

			// Token: 0x04002E81 RID: 11905
			[Token(Token = "0x4002E81")]
			[FieldOffset(Offset = "0x34")]
			public BattleBonusesAdModel Model;

			// Token: 0x04002E82 RID: 11906
			[Token(Token = "0x4002E82")]
			[FieldOffset(Offset = "0x38")]
			public BattleBonusesAdEvents Events;
		}
	}
}
