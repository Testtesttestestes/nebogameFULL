using System;
using System.Collections.Generic;
using AssetContent;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameplay.Cave;
using Gameplay.Cave.Controller;
using Gameplay.Horde.View;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UI.Wiki;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	public class CaveWindow : BaseBuildingWindow<CaveWindowArgs>
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024E")]
		public override string WindowId
		{
			[Token(Token = "0x6001023")]
			[Address(RVA = "0x622D", Offset = "0x622D", VA = "0x622D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024F")]
		public Button SearchButton
		{
			[Token(Token = "0x6001024")]
			[Address(RVA = "0x622E", Offset = "0x622E", VA = "0x622E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000250")]
		public Button ChestButton
		{
			[Token(Token = "0x6001025")]
			[Address(RVA = "0x622F", Offset = "0x622F", VA = "0x622F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000251")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x6001026")]
			[Address(RVA = "0x6230", Offset = "0x6230", VA = "0x6230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000252")]
		public MonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x6001027")]
			[Address(RVA = "0x6231", Offset = "0x6231", VA = "0x6231")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000253")]
		public HordeView HordeView
		{
			[Token(Token = "0x6001028")]
			[Address(RVA = "0x6232", Offset = "0x6232", VA = "0x6232")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000254")]
		public string ResourceImageAssetId
		{
			[Token(Token = "0x6001029")]
			[Address(RVA = "0x6233", Offset = "0x6233", VA = "0x6233")]
			get
			{
				return null;
			}
			[Token(Token = "0x600102A")]
			[Address(RVA = "0x6234", Offset = "0x6234", VA = "0x6234")]
			set
			{
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000255")]
		public string ResourceText
		{
			[Token(Token = "0x600102B")]
			[Address(RVA = "0x6235", Offset = "0x6235", VA = "0x6235")]
			get
			{
				return null;
			}
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x6236", Offset = "0x6236", VA = "0x6236")]
			set
			{
			}
		}

		// Token: 0x17000256 RID: 598
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000256")]
		public int ResourceAmount
		{
			[Token(Token = "0x600102D")]
			[Address(RVA = "0x6237", Offset = "0x6237", VA = "0x6237")]
			set
			{
			}
		}

		// Token: 0x17000257 RID: 599
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000257")]
		public bool Active
		{
			[Token(Token = "0x600102E")]
			[Address(RVA = "0x6238", Offset = "0x6238", VA = "0x6238")]
			set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000258")]
		public Price SearchPrice
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x6239", Offset = "0x6239", VA = "0x6239")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x623A", Offset = "0x623A", VA = "0x623A", Slot = "22")]
		protected override void OnShow(CaveWindowArgs args)
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x623B", Offset = "0x623B", VA = "0x623B")]
		private void InitMVC()
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x623C", Offset = "0x623C", VA = "0x623C")]
		private void DeinitMVC()
		{
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x623D", Offset = "0x623D", VA = "0x623D", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x623E", Offset = "0x623E", VA = "0x623E", Slot = "17")]
		public override bool CheckForClose()
		{
			return default(bool);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x623F", Offset = "0x623F", VA = "0x623F")]
		public CaveWindow()
		{
		}

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/CavePopupWindow";

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _tip;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _searchButton;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Price _searchPrice;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameRawImage _resouceImage;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _resourceAmountBG;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _resourceAmount;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _chestButton;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private List<RectTransform> _windowComponents;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MonsterInfoView _monsterInfoView;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private HordeView _hordeView;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x6C")]
		private TweenerCore<Color, Color, ColorOptions> _tweenerCore;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x70")]
		private CaveEvents _events;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x74")]
		private CaveModel _model;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x78")]
		private CaveController _controller;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x7C")]
		private CaveWindowMediator _caveViewMediator;
	}
}
