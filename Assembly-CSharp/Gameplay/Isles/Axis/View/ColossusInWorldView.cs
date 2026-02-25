using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.ToolTip;
using UI.ToolTip.Implementations;
using UnityEngine;
using UnityEngine.UI;
using Utils.Timers;

namespace Gameplay.Isles.Axis.View
{
	// Token: 0x02000D04 RID: 3332
	[Token(Token = "0x2000D04")]
	public class ColossusInWorldView : MonoBehaviourWithStates<ColossusInWorldView.State>, IToolTipDataProvider
	{
		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001078")]
		private DelayedCall ShieldTimer
		{
			[Token(Token = "0x6005152")]
			[Address(RVA = "0x9F31", Offset = "0x9F31", VA = "0x9F31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001079")]
		private Dictionary<ColossusBattleData.State, Sprite> SwordsIconByStateDict
		{
			[Token(Token = "0x6005153")]
			[Address(RVA = "0x9F32", Offset = "0x9F32", VA = "0x9F32")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005155 RID: 20821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107A")]
		public ColossusBattleData ColossusData
		{
			[Token(Token = "0x6005154")]
			[Address(RVA = "0x9F33", Offset = "0x9F33", VA = "0x9F33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005155")]
			[Address(RVA = "0x9F34", Offset = "0x9F34", VA = "0x9F34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700107B")]
		public GameAssetViewSpriteRenderer AssetViewSpriteRenderer
		{
			[Token(Token = "0x6005156")]
			[Address(RVA = "0x9F35", Offset = "0x9F35", VA = "0x9F35")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001ED RID: 493
		// (add) Token: 0x06005157 RID: 20823 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005158 RID: 20824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001ED")]
		public event Action<ColossusBattleData> ClickedEvent
		{
			[Token(Token = "0x6005157")]
			[Address(RVA = "0x9F36", Offset = "0x9F36", VA = "0x9F36")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005158")]
			[Address(RVA = "0x9F37", Offset = "0x9F37", VA = "0x9F37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005159")]
		[Address(RVA = "0x9F38", Offset = "0x9F38", VA = "0x9F38")]
		private void Awake()
		{
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515A")]
		[Address(RVA = "0x9F39", Offset = "0x9F39", VA = "0x9F39")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515B")]
		[Address(RVA = "0x9F3A", Offset = "0x9F3A", VA = "0x9F3A")]
		private void AssetViewClickedEventHandler(GameAssetViewSpriteRenderer gameAssetView)
		{
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515C")]
		[Address(RVA = "0x9F3B", Offset = "0x9F3B", VA = "0x9F3B")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515D")]
		[Address(RVA = "0x9F3C", Offset = "0x9F3C", VA = "0x9F3C")]
		public void Init(ColossusBattleData data)
		{
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515E")]
		[Address(RVA = "0x9F3D", Offset = "0x9F3D", VA = "0x9F3D")]
		public void Init(ColossusDic dic)
		{
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515F")]
		[Address(RVA = "0x9F3E", Offset = "0x9F3E", VA = "0x9F3E")]
		private void UpdateState()
		{
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005160")]
		[Address(RVA = "0x9F3F", Offset = "0x9F3F", VA = "0x9F3F", Slot = "5")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005161")]
		[Address(RVA = "0x9F40", Offset = "0x9F40", VA = "0x9F40")]
		private BaseToolTipData GetShieldTooltipData()
		{
			return null;
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005162")]
		[Address(RVA = "0x9F41", Offset = "0x9F41", VA = "0x9F41")]
		private BaseToolTipData GetAttackCostTooltip()
		{
			return null;
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005163")]
		[Address(RVA = "0x9F42", Offset = "0x9F42", VA = "0x9F42")]
		public ColossusInWorldView()
		{
		}

		// Token: 0x04002C41 RID: 11329
		[Token(Token = "0x4002C41")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetView;

		// Token: 0x04002C42 RID: 11330
		[Token(Token = "0x4002C42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldAxisScheduleView.SpriteByState[] _iconByState;

		// Token: 0x04002C43 RID: 11331
		[Token(Token = "0x4002C43")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SpriteRenderer _stateIcon;

		// Token: 0x04002C44 RID: 11332
		[Token(Token = "0x4002C44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeView _backtime;

		// Token: 0x04002C45 RID: 11333
		[Token(Token = "0x4002C45")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToolTipDelegate _shieldIconTooltip;

		// Token: 0x04002C46 RID: 11334
		[Token(Token = "0x4002C46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ToolTipDelegate _actionIconTooltip;

		// Token: 0x04002C47 RID: 11335
		[Token(Token = "0x4002C47")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _button;

		// Token: 0x04002C48 RID: 11336
		[Token(Token = "0x4002C48")]
		[FieldOffset(Offset = "0x38")]
		private DelayedCall _shieldTimer;

		// Token: 0x04002C49 RID: 11337
		[Token(Token = "0x4002C49")]
		[FieldOffset(Offset = "0x3C")]
		private Dictionary<ColossusBattleData.State, Sprite> _swordsIconByStateDict;

		// Token: 0x02000D05 RID: 3333
		[Token(Token = "0x2000D05")]
		public enum State
		{
			// Token: 0x04002C4D RID: 11341
			[Token(Token = "0x4002C4D")]
			UNKNOWN_STATE,
			// Token: 0x04002C4E RID: 11342
			[Token(Token = "0x4002C4E")]
			ACTIVE,
			// Token: 0x04002C4F RID: 11343
			[Token(Token = "0x4002C4F")]
			DISABLED
		}
	}
}
