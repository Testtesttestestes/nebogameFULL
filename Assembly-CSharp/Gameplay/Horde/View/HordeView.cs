using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Horde.Controller;
using Gameplay.Horde.Model;
using Gameplay.Horde.Model.Data;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Elements.RightPanel;
using UI.Elements.RightPanel.TitledList;
using UI.Elements.RightPanel.TitledList.Elements;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006FD RID: 1789
	[Token(Token = "0x20006FD")]
	public class HordeView : MonoBehaviour
	{
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x00008628 File Offset: 0x00006828
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081C")]
		public bool AllowClose
		{
			[Token(Token = "0x6002AC4")]
			[Address(RVA = "0x7B5F", Offset = "0x7B5F", VA = "0x7B5F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002AC5")]
			[Address(RVA = "0x7B60", Offset = "0x7B60", VA = "0x7B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081D")]
		public IMonsterSource MonsterSource
		{
			[Token(Token = "0x6002AC6")]
			[Address(RVA = "0x7B61", Offset = "0x7B61", VA = "0x7B61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC7")]
			[Address(RVA = "0x7B62", Offset = "0x7B62", VA = "0x7B62")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081E")]
		public IWindowWithCloseBackButtons MasterWindow
		{
			[Token(Token = "0x6002AC8")]
			[Address(RVA = "0x7B63", Offset = "0x7B63", VA = "0x7B63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC9")]
			[Address(RVA = "0x7B64", Offset = "0x7B64", VA = "0x7B64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700081F")]
		public ButtonWithCost AttackButton
		{
			[Token(Token = "0x6002ACA")]
			[Address(RVA = "0x7B65", Offset = "0x7B65", VA = "0x7B65")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000820")]
		public ButtonWithCost KickButton
		{
			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0x7B66", Offset = "0x7B66", VA = "0x7B66")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400015C RID: 348
		// (add) Token: 0x06002ACC RID: 10956 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002ACD RID: 10957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015C")]
		public event Action<uint> RequestHordeInfoEvent
		{
			[Token(Token = "0x6002ACC")]
			[Address(RVA = "0x7B67", Offset = "0x7B67", VA = "0x7B67")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002ACD")]
			[Address(RVA = "0x7B68", Offset = "0x7B68", VA = "0x7B68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000821 RID: 2081
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000821")]
		public uint MainMonsterId
		{
			[Token(Token = "0x6002ACE")]
			[Address(RVA = "0x7B69", Offset = "0x7B69", VA = "0x7B69")]
			set
			{
			}
		}

		// Token: 0x17000822 RID: 2082
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000822")]
		public string Difficulty
		{
			[Token(Token = "0x6002ACF")]
			[Address(RVA = "0x7B6A", Offset = "0x7B6A", VA = "0x7B6A")]
			set
			{
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x7B6B", Offset = "0x7B6B", VA = "0x7B6B")]
		private void Awake()
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x7B6C", Offset = "0x7B6C", VA = "0x7B6C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x7B6D", Offset = "0x7B6D", VA = "0x7B6D")]
		public void InitMasterWindowStatus(IWindowWithCloseBackButtons masterWindow, IMonsterSource monsterSource)
		{
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0x7B6E", Offset = "0x7B6E", VA = "0x7B6E")]
		public HordeMonsterAprView[] Init(IList<HordeMonsterData> hordeMonsters, int currentMonsterIndex, Action<HordeMonsterAprView> callback)
		{
			return null;
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x7B6F", Offset = "0x7B6F", VA = "0x7B6F")]
		private HordeMonsterAprView SpawnMonsterApr(int index, HordeMonsterData monster, bool defeated, Action<HordeMonsterAprView> callback)
		{
			return null;
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x7B70", Offset = "0x7B70", VA = "0x7B70")]
		public void UpdateInfo(string title, string description, BattleAccount account, HordeMonsterData monster, UserData user)
		{
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x7B71", Offset = "0x7B71", VA = "0x7B71")]
		private void SetupMVC()
		{
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x7B72", Offset = "0x7B72", VA = "0x7B72")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x7B73", Offset = "0x7B73", VA = "0x7B73")]
		public HordeView()
		{
		}

		// Token: 0x0400175C RID: 5980
		[Token(Token = "0x400175C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private HordeMonsterAprView _monsterAprPrefab;

		// Token: 0x0400175D RID: 5981
		[Token(Token = "0x400175D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _separatorArrowPrefab;

		// Token: 0x0400175E RID: 5982
		[Token(Token = "0x400175E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TitleWithLevel _windowTitle;

		// Token: 0x0400175F RID: 5983
		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _attackButton;

		// Token: 0x04001760 RID: 5984
		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _kickButton;

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TitledList _titledList;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04001763 RID: 5987
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewRawImage _gameAssetView;

		// Token: 0x04001764 RID: 5988
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x30")]
		private HordeViewMediator _mediator;

		// Token: 0x04001765 RID: 5989
		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x34")]
		private HordeModel _model;

		// Token: 0x04001766 RID: 5990
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x38")]
		private HordeController _controller;

		// Token: 0x04001767 RID: 5991
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x3C")]
		private bool _mvcSetUp;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x4C")]
		private MonsterDifficultyTitledListElement _monsterDifficulty;

		// Token: 0x0400176D RID: 5997
		[Token(Token = "0x400176D")]
		[FieldOffset(Offset = "0x50")]
		private RewardsTitledListElement _rewards;
	}
}
