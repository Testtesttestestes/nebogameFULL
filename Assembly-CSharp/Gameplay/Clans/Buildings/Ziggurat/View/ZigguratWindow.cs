using System;
using AssetContent;
using Gameplay.Clans.Ziggurat.Controller;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Price;
using UI.Windows.Buildings;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Buildings.Ziggurat.View
{
	// Token: 0x02000AAD RID: 2733
	[Token(Token = "0x2000AAD")]
	public class ZigguratWindow : BaseClanBuildingWindow<ZigguratWindow.ZigguratWindowArgs>
	{
		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CF8")]
		public override string WindowId
		{
			[Token(Token = "0x60041F0")]
			[Address(RVA = "0x90A4", Offset = "0x90A4", VA = "0x90A4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CF9")]
		public ZigguratView ZigguratView
		{
			[Token(Token = "0x60041F1")]
			[Address(RVA = "0x90A5", Offset = "0x90A5", VA = "0x90A5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060041F2 RID: 16882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CFA")]
		public GameAssetViewRawImage BrokenImage
		{
			[Token(Token = "0x60041F2")]
			[Address(RVA = "0x90A6", Offset = "0x90A6", VA = "0x90A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CFB")]
		public IndexButtonBasic InClanButton
		{
			[Token(Token = "0x60041F3")]
			[Address(RVA = "0x90A7", Offset = "0x90A7", VA = "0x90A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060041F4 RID: 16884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CFC")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x60041F4")]
			[Address(RVA = "0x90A8", Offset = "0x90A8", VA = "0x90A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CFD")]
		public GameObject LeaderGroup
		{
			[Token(Token = "0x60041F5")]
			[Address(RVA = "0x90A9", Offset = "0x90A9", VA = "0x90A9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CFE")]
		public Button RepairButton
		{
			[Token(Token = "0x60041F6")]
			[Address(RVA = "0x90AA", Offset = "0x90AA", VA = "0x90AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CFF")]
		public Price RepairPrice
		{
			[Token(Token = "0x60041F7")]
			[Address(RVA = "0x90AB", Offset = "0x90AB", VA = "0x90AB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D00")]
		public GameObject TitledListBroken
		{
			[Token(Token = "0x60041F8")]
			[Address(RVA = "0x90AC", Offset = "0x90AC", VA = "0x90AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041F9")]
		[Address(RVA = "0x90AD", Offset = "0x90AD", VA = "0x90AD", Slot = "22")]
		protected override void OnShow(ZigguratWindow.ZigguratWindowArgs args)
		{
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041FA")]
		[Address(RVA = "0x90AE", Offset = "0x90AE", VA = "0x90AE", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041FB")]
		[Address(RVA = "0x90AF", Offset = "0x90AF", VA = "0x90AF")]
		public ZigguratWindow()
		{
		}

		// Token: 0x04002459 RID: 9305
		[Token(Token = "0x4002459")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Buildings/ZigguratWindow";

		// Token: 0x0400245A RID: 9306
		[Token(Token = "0x400245A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ZigguratView _zigguratView;

		// Token: 0x0400245B RID: 9307
		[Token(Token = "0x400245B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameAssetViewRawImage _brokenImage;

		// Token: 0x0400245C RID: 9308
		[Token(Token = "0x400245C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private IndexButtonBasic _inClanButton;

		// Token: 0x0400245D RID: 9309
		[Token(Token = "0x400245D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400245E RID: 9310
		[Token(Token = "0x400245E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _leaderGroup;

		// Token: 0x0400245F RID: 9311
		[Token(Token = "0x400245F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _repairButton;

		// Token: 0x04002460 RID: 9312
		[Token(Token = "0x4002460")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Price _repairPrice;

		// Token: 0x04002461 RID: 9313
		[Token(Token = "0x4002461")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _titledListBroken;

		// Token: 0x04002462 RID: 9314
		[Token(Token = "0x4002462")]
		[FieldOffset(Offset = "0x60")]
		private ZigguratViewMediator _mediator;

		// Token: 0x02000AAE RID: 2734
		[Token(Token = "0x2000AAE")]
		public class ZigguratWindowArgs : BaseClanBuildingWindowArgs
		{
			// Token: 0x060041FC RID: 16892 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60041FC")]
			[Address(RVA = "0x90B0", Offset = "0x90B0", VA = "0x90B0")]
			public ZigguratWindowArgs(ClanIsle isle, uint buildingTypeId)
			{
			}
		}
	}
}
