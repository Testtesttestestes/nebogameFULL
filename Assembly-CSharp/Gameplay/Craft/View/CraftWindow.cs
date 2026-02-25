using System;
using System.Collections.Generic;
using Gameplay.Craft.Controller;
using Gameplay.Craft.Events;
using Gameplay.Craft.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UI.Filters;
using UI.Tabs;
using UI.Toggle;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B8 RID: 2232
	[Token(Token = "0x20008B8")]
	public class CraftWindow : ClosableBaseWindow<CraftWindow.CraftWindowArgs>
	{
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A64")]
		public override string WindowId
		{
			[Token(Token = "0x600346E")]
			[Address(RVA = "0x8498", Offset = "0x8498", VA = "0x8498", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A65")]
		public TabBar TabBar
		{
			[Token(Token = "0x600346F")]
			[Address(RVA = "0x8499", Offset = "0x8499", VA = "0x8499")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A66")]
		public CraftInfoBox InfoBox
		{
			[Token(Token = "0x6003470")]
			[Address(RVA = "0x849A", Offset = "0x849A", VA = "0x849A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A67")]
		public TextMeshProUGUI ProfessionLevelText
		{
			[Token(Token = "0x6003471")]
			[Address(RVA = "0x849B", Offset = "0x849B", VA = "0x849B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A68")]
		public ProgressBarWithText ProgressBar
		{
			[Token(Token = "0x6003472")]
			[Address(RVA = "0x849C", Offset = "0x849C", VA = "0x849C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A69")]
		public Button MaxLevelButton
		{
			[Token(Token = "0x6003473")]
			[Address(RVA = "0x849D", Offset = "0x849D", VA = "0x849D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6A")]
		public TextMeshProUGUI MaxLevelText
		{
			[Token(Token = "0x6003474")]
			[Address(RVA = "0x849E", Offset = "0x849E", VA = "0x849E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6B")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6003475")]
			[Address(RVA = "0x849F", Offset = "0x849F", VA = "0x849F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6C")]
		public CraftWindowStates WindowStates
		{
			[Token(Token = "0x6003476")]
			[Address(RVA = "0x84A0", Offset = "0x84A0", VA = "0x84A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6D")]
		public GreenToggle CompletedToggle
		{
			[Token(Token = "0x6003477")]
			[Address(RVA = "0x84A1", Offset = "0x84A1", VA = "0x84A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6E")]
		public Button InChestButton
		{
			[Token(Token = "0x6003478")]
			[Address(RVA = "0x84A2", Offset = "0x84A2", VA = "0x84A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x84A3", Offset = "0x84A3", VA = "0x84A3")]
		public void Init()
		{
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x84A4", Offset = "0x84A4", VA = "0x84A4", Slot = "22")]
		protected override void OnShow(CraftWindow.CraftWindowArgs args)
		{
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x84A5", Offset = "0x84A5", VA = "0x84A5", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x84A6", Offset = "0x84A6", VA = "0x84A6")]
		public void SetRecipes(IList<CraftRecipeListElement.CraftRecipeListElementArgs> items)
		{
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x84A7", Offset = "0x84A7", VA = "0x84A7")]
		public List<CraftSlotListElement> CreateManufactureSlots(IList<CraftSlotDic> dics, Action<CraftSlotListElement> selectCallback)
		{
			return null;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x84A8", Offset = "0x84A8", VA = "0x84A8")]
		public void SetCounter(int currentValue, int totalValue)
		{
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x84A9", Offset = "0x84A9", VA = "0x84A9")]
		public void ScrollTo(int index)
		{
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x84AA", Offset = "0x84AA", VA = "0x84AA")]
		private void SetupMVC()
		{
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x84AB", Offset = "0x84AB", VA = "0x84AB")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x84AC", Offset = "0x84AC", VA = "0x84AC")]
		public CraftWindow()
		{
		}

		// Token: 0x04001CA4 RID: 7332
		[Token(Token = "0x4001CA4")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/CraftWindow";

		// Token: 0x04001CA5 RID: 7333
		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CraftWindowStates _windowStates;

		// Token: 0x04001CA6 RID: 7334
		[Token(Token = "0x4001CA6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04001CA7 RID: 7335
		[Token(Token = "0x4001CA7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private CraftRecipesOSAView _oSAView;

		// Token: 0x04001CA8 RID: 7336
		[Token(Token = "0x4001CA8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001CA9 RID: 7337
		[Token(Token = "0x4001CA9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CraftInfoBox _infoBox;

		// Token: 0x04001CAA RID: 7338
		[Token(Token = "0x4001CAA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _professionLevelText;

		// Token: 0x04001CAB RID: 7339
		[Token(Token = "0x4001CAB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ProgressBarWithText _progressBar;

		// Token: 0x04001CAC RID: 7340
		[Token(Token = "0x4001CAC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _maxLevelButton;

		// Token: 0x04001CAD RID: 7341
		[Token(Token = "0x4001CAD")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _maxLevelText;

		// Token: 0x04001CAE RID: 7342
		[Token(Token = "0x4001CAE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CraftSlotsView _craftSlots;

		// Token: 0x04001CAF RID: 7343
		[Token(Token = "0x4001CAF")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private GreenToggle _completedToggle;

		// Token: 0x04001CB0 RID: 7344
		[Token(Token = "0x4001CB0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI _craftSlotsCounterText;

		// Token: 0x04001CB1 RID: 7345
		[Token(Token = "0x4001CB1")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _inChestButton;

		// Token: 0x04001CB2 RID: 7346
		[Token(Token = "0x4001CB2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] _enableOnInit;

		// Token: 0x04001CB3 RID: 7347
		[Token(Token = "0x4001CB3")]
		[FieldOffset(Offset = "0x74")]
		private CraftModel _model;

		// Token: 0x04001CB4 RID: 7348
		[Token(Token = "0x4001CB4")]
		[FieldOffset(Offset = "0x78")]
		private CraftEvents _events;

		// Token: 0x04001CB5 RID: 7349
		[Token(Token = "0x4001CB5")]
		[FieldOffset(Offset = "0x7C")]
		private CraftController _controller;

		// Token: 0x04001CB6 RID: 7350
		[Token(Token = "0x4001CB6")]
		[FieldOffset(Offset = "0x80")]
		private CraftViewMediator _mediator;

		// Token: 0x04001CB7 RID: 7351
		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x84")]
		private bool _mvcSetUp;

		// Token: 0x020008B9 RID: 2233
		[Token(Token = "0x20008B9")]
		public class CraftWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003483 RID: 13443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003483")]
			[Address(RVA = "0x84AD", Offset = "0x84AD", VA = "0x84AD")]
			public CraftWindowArgs()
			{
			}

			// Token: 0x04001CB8 RID: 7352
			[Token(Token = "0x4001CB8")]
			[FieldOffset(Offset = "0x18")]
			public uint SchemeId;
		}
	}
}
