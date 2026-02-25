using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C69 RID: 3177
	[Token(Token = "0x2000C69")]
	public class BankViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, BankWindow>
	{
		// Token: 0x06004D98 RID: 19864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D98")]
		[Address(RVA = "0x9BD0", Offset = "0x9BD0", VA = "0x9BD0", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D99")]
		[Address(RVA = "0x9BD1", Offset = "0x9BD1", VA = "0x9BD1")]
		public BankViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		}

		// Token: 0x17000FB9 RID: 4025
		// (set) Token: 0x06004D9A RID: 19866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB9")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D9A")]
			[Address(RVA = "0x9BD2", Offset = "0x9BD2", VA = "0x9BD2", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9B")]
		[Address(RVA = "0x9BD3", Offset = "0x9BD3", VA = "0x9BD3")]
		private void SingleTimeSellOptionPurchaseStatusChangedEvent(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9C")]
		[Address(RVA = "0x9BD4", Offset = "0x9BD4", VA = "0x9BD4")]
		private void HandleAvailOptionsChangedEvent()
		{
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0x9BD5", Offset = "0x9BD5", VA = "0x9BD5")]
		private void HandleOptionsRewardsChangedEvent()
		{
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0x9BD6", Offset = "0x9BD6", VA = "0x9BD6")]
		private void ReDrawTabs()
		{
		}

		// Token: 0x17000FBA RID: 4026
		// (set) Token: 0x06004D9F RID: 19871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FBA")]
		public override BankWindow View
		{
			[Token(Token = "0x6004D9F")]
			[Address(RVA = "0x9BD7", Offset = "0x9BD7", VA = "0x9BD7", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA0")]
		[Address(RVA = "0x9BD8", Offset = "0x9BD8", VA = "0x9BD8")]
		private void ResetView()
		{
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA1")]
		[Address(RVA = "0x9BD9", Offset = "0x9BD9", VA = "0x9BD9")]
		private void SetupView()
		{
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DA2")]
		[Address(RVA = "0x9BDA", Offset = "0x9BDA", VA = "0x9BDA")]
		private IEnumerator CheckBackTimersCoroutine()
		{
			return null;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA3")]
		[Address(RVA = "0x9BDB", Offset = "0x9BDB", VA = "0x9BDB")]
		private void StopCheckBacktimersCoroutine()
		{
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0x9BDC", Offset = "0x9BDC", VA = "0x9BDC")]
		private void CheckBackTimers()
		{
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA5")]
		[Address(RVA = "0x9BDD", Offset = "0x9BDD", VA = "0x9BDD")]
		private void BankOptionsListViewOnFaqButtonClickedEvent(BankOptionView bankOptionView)
		{
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA6")]
		[Address(RVA = "0x9BDE", Offset = "0x9BDE", VA = "0x9BDE")]
		private void BankOptionsListViewOnBuyButtonClickedEvent(IBankOptionView bankOptionView)
		{
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DA7")]
		[Address(RVA = "0x9BDF", Offset = "0x9BDF", VA = "0x9BDF")]
		private IEnumerable<TabBarItemData> GetCurrentTabs()
		{
			return null;
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA8")]
		[Address(RVA = "0x9BE0", Offset = "0x9BE0", VA = "0x9BE0")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x9BE1", Offset = "0x9BE1", VA = "0x9BE1")]
		private void RedrawCurrentTab([Optional] TabBarItemData<BankTabData> tab)
		{
		}

		// Token: 0x04002A4D RID: 10829
		[Token(Token = "0x4002A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Coroutine _checkBackTimersCoroutine;

		// Token: 0x04002A4E RID: 10830
		[Token(Token = "0x4002A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _isInitialized;
	}
}
