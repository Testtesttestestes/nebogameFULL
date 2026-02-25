using System;
using System.Collections.Generic;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.SmallGames;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	public class WinningCombinationsWindow : ClosableBaseWindow<WinningCombinationsWindow.WinningCombinationsWindowArgs>
	{
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BE")]
		public override string WindowId
		{
			[Token(Token = "0x6001F77")]
			[Address(RVA = "0x70DC", Offset = "0x70DC", VA = "0x70DC", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x70DD", Offset = "0x70DD", VA = "0x70DD", Slot = "22")]
		protected override void OnShow(WinningCombinationsWindow.WinningCombinationsWindowArgs args)
		{
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x70DE", Offset = "0x70DE", VA = "0x70DE")]
		private TabBarItemData[] ConstructTabBarDataArray()
		{
			return null;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x70DF", Offset = "0x70DF", VA = "0x70DF")]
		public WinningCombinationsWindow()
		{
		}

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/WinningCombinationsWindow";

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		private const string DIAMOND_COMBINATIONS = "SMALL_GAMES/DIAMOND_COMBINATIONS";

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		private const string ONYX_COMBINATIONS = "SMALL_GAMES/ONYX_COMBINATIONS";

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		private const int CLOVER_ICON_ID = 1;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private WinningCombinationRow _rowPrefab;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameRawImage[] _cloverIcons;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _bottomAnnotation;

		// Token: 0x0200052B RID: 1323
		[Token(Token = "0x200052B")]
		public class WinningCombinationsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001F7B RID: 8059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F7B")]
			[Address(RVA = "0x70E0", Offset = "0x70E0", VA = "0x70E0")]
			public WinningCombinationsWindowArgs()
			{
			}

			// Token: 0x04001130 RID: 4400
			[Token(Token = "0x4001130")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<uint, WinCombinationDic> WinCombinations;

			// Token: 0x04001131 RID: 4401
			[Token(Token = "0x4001131")]
			[FieldOffset(Offset = "0x1C")]
			public SlotMachineType SlotMachineType;

			// Token: 0x04001132 RID: 4402
			[Token(Token = "0x4001132")]
			[FieldOffset(Offset = "0x20")]
			public SlotMachineDic SlotMachineDic;
		}
	}
}
