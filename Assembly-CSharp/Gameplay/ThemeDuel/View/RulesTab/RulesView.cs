using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ThemeDuel.View.RulesTab
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	public class RulesView : MonoBehaviourWithStates<RulesView.RulesTabState>
	{
		// Token: 0x06001DD3 RID: 7635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0x6F51", Offset = "0x6F51", VA = "0x6F51")]
		public RulesView()
		{
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055D")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x6F52", Offset = "0x6F52", VA = "0x6F52")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055E")]
		public GameRawImageLoader MainTitleImageLoader
		{
			[Token(Token = "0x6001DD5")]
			[Address(RVA = "0x6F53", Offset = "0x6F53", VA = "0x6F53")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700055F")]
		public GameRawImageLoader TextBottomImageLoader
		{
			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0x6F54", Offset = "0x6F54", VA = "0x6F54")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000560")]
		public ButtonWithCost InDuelButton
		{
			[Token(Token = "0x6001DD7")]
			[Address(RVA = "0x6F55", Offset = "0x6F55", VA = "0x6F55")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000561")]
		public BacktimeViewUGUI CombatStageBackTimer
		{
			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x6F56", Offset = "0x6F56", VA = "0x6F56")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000562")]
		public Button VideoHandBookButton
		{
			[Token(Token = "0x6001DD9")]
			[Address(RVA = "0x6F57", Offset = "0x6F57", VA = "0x6F57")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001036 RID: 4150
		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImageLoader _mainTitleImageLoader;

		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameRawImageLoader _textBottomImageLoader;

		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BacktimeViewUGUI _combatStageBackTimer;

		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _videoHandBookButton;

		// Token: 0x020004E1 RID: 1249
		[Token(Token = "0x20004E1")]
		public enum RulesTabState
		{
			// Token: 0x0400103C RID: 4156
			[Token(Token = "0x400103C")]
			Unknown,
			// Token: 0x0400103D RID: 4157
			[Token(Token = "0x400103D")]
			EventActive,
			// Token: 0x0400103E RID: 4158
			[Token(Token = "0x400103E")]
			EventFinished
		}
	}
}
