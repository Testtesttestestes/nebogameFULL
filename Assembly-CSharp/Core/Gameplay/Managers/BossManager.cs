using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Gameplay.Combat;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001145 RID: 4421
	[Token(Token = "0x2001145")]
	public class BossManager : IGameManager, IBaseManager
	{
		// Token: 0x14000266 RID: 614
		// (add) Token: 0x060067E8 RID: 26600 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067E9 RID: 26601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000266")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067E8")]
			[Address(RVA = "0xB314", Offset = "0xB314", VA = "0xB314", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067E9")]
			[Address(RVA = "0xB315", Offset = "0xB315", VA = "0xB315", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000267 RID: 615
		// (add) Token: 0x060067EA RID: 26602 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067EB RID: 26603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000267")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067EA")]
			[Address(RVA = "0xB316", Offset = "0xB316", VA = "0xB316", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067EB")]
			[Address(RVA = "0xB317", Offset = "0xB317", VA = "0xB317", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001549")]
		public BossController Controller
		{
			[Token(Token = "0x60067EC")]
			[Address(RVA = "0xB318", Offset = "0xB318", VA = "0xB318")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060067ED RID: 26605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700154A")]
		public BossEvents Events
		{
			[Token(Token = "0x60067ED")]
			[Address(RVA = "0xB319", Offset = "0xB319", VA = "0xB319")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700154B")]
		public BossModel Model
		{
			[Token(Token = "0x60067EE")]
			[Address(RVA = "0xB31A", Offset = "0xB31A", VA = "0xB31A")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067EF")]
		[Address(RVA = "0xB31B", Offset = "0xB31B", VA = "0xB31B", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F0")]
		[Address(RVA = "0xB31C", Offset = "0xB31C", VA = "0xB31C")]
		private void InitEvent()
		{
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F1")]
		[Address(RVA = "0xB31D", Offset = "0xB31D", VA = "0xB31D")]
		private void SetupMvc()
		{
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F2")]
		[Address(RVA = "0xB31E", Offset = "0xB31E", VA = "0xB31E")]
		private void DestroyMvc()
		{
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F3")]
		[Address(RVA = "0xB31F", Offset = "0xB31F", VA = "0xB31F", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700154C")]
		public string Name
		{
			[Token(Token = "0x60067F4")]
			[Address(RVA = "0xB320", Offset = "0xB320", VA = "0xB320", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F5")]
		[Address(RVA = "0xB321", Offset = "0xB321", VA = "0xB321")]
		public void ShowBossListWindow()
		{
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F6")]
		[Address(RVA = "0xB322", Offset = "0xB322", VA = "0xB322")]
		public void ShowBossWindow(BossInstance bossInstance, BossWindowState tab = BossWindowState.CAPTAIN_STATE)
		{
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F7")]
		[Address(RVA = "0xB323", Offset = "0xB323", VA = "0xB323")]
		public void ShowBossWindow(long instanceId, BossWindowState tab = BossWindowState.CAPTAIN_STATE)
		{
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F8")]
		[Address(RVA = "0xB324", Offset = "0xB324", VA = "0xB324")]
		public void ShowBossRewardingWindow(BossInstance bossInstance, List<ulong> teamIds, int selectedIndex = 0)
		{
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F9")]
		[Address(RVA = "0xB325", Offset = "0xB325", VA = "0xB325")]
		public void ShowBossRewardingWindow(long instanceId, List<ulong> teamIds, int selectedIndex = 0)
		{
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FA")]
		[Address(RVA = "0xB326", Offset = "0xB326", VA = "0xB326")]
		public void ShowBossMinionWindow(ICombat combat, MonsterData monsterData, BackTime backTime)
		{
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x00013860 File Offset: 0x00011A60
		[Token(Token = "0x60067FB")]
		[Address(RVA = "0xB327", Offset = "0xB327", VA = "0xB327")]
		public bool TryRunBossCombat(BossInstance bossInstance, BackTime backTime, out ICombat combat)
		{
			return default(bool);
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x00013878 File Offset: 0x00011A78
		[Token(Token = "0x60067FC")]
		[Address(RVA = "0xB328", Offset = "0xB328", VA = "0xB328")]
		public bool TryRunBossMinionCombat(BackTime backTime, out ICombat combat)
		{
			return default(bool);
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FD")]
		[Address(RVA = "0xB329", Offset = "0xB329", VA = "0xB329")]
		public BossManager()
		{
		}

		// Token: 0x04003768 RID: 14184
		[Token(Token = "0x4003768")]
		[FieldOffset(Offset = "0x10")]
		private BossController _controller;

		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x14")]
		private BossEvents _events;

		// Token: 0x0400376A RID: 14186
		[Token(Token = "0x400376A")]
		[FieldOffset(Offset = "0x18")]
		private BossModel _model;
	}
}
