using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.ListView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BAB RID: 2987
	[Token(Token = "0x2000BAB")]
	public class BossListWindowMediator : AbstractViewMediator<BossModel, BossEvents, BossController, BossListWindow>
	{
		// Token: 0x06004932 RID: 18738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004932")]
		[Address(RVA = "0x97A4", Offset = "0x97A4", VA = "0x97A4", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004933")]
		[Address(RVA = "0x97A5", Offset = "0x97A5", VA = "0x97A5")]
		public BossListWindowMediator(BossModel model, BossEvents events, BossController controller)
		{
		}

		// Token: 0x17000ED6 RID: 3798
		// (set) Token: 0x06004934 RID: 18740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED6")]
		public override BossListWindow View
		{
			[Token(Token = "0x6004934")]
			[Address(RVA = "0x97A6", Offset = "0x97A6", VA = "0x97A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004935")]
		[Address(RVA = "0x97A7", Offset = "0x97A7", VA = "0x97A7")]
		private void ResetView()
		{
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004936")]
		[Address(RVA = "0x97A8", Offset = "0x97A8", VA = "0x97A8")]
		private void SetupView()
		{
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004937")]
		[Address(RVA = "0x97A9", Offset = "0x97A9", VA = "0x97A9")]
		private void BossListAdapterOnQuestionButtonClickedEvent(BossInstance data)
		{
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004938")]
		[Address(RVA = "0x97AA", Offset = "0x97AA", VA = "0x97AA")]
		private void GreenToggleOnChangedEvent()
		{
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004939")]
		[Address(RVA = "0x97AB", Offset = "0x97AB", VA = "0x97AB")]
		private void ActionButtonClickHandler()
		{
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493A")]
		[Address(RVA = "0x97AC", Offset = "0x97AC", VA = "0x97AC")]
		private void BossListAdapterOnSelectedEvent(BossInstance bossInstance)
		{
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493B")]
		[Address(RVA = "0x97AD", Offset = "0x97AD", VA = "0x97AD")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493C")]
		[Address(RVA = "0x97AE", Offset = "0x97AE", VA = "0x97AE")]
		private void RenderList()
		{
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493D")]
		[Address(RVA = "0x97AF", Offset = "0x97AF", VA = "0x97AF")]
		private void UpdateList()
		{
		}

		// Token: 0x17000ED7 RID: 3799
		// (set) Token: 0x0600493E RID: 18750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED7")]
		public override BossEvents Events
		{
			[Token(Token = "0x600493E")]
			[Address(RVA = "0x97B0", Offset = "0x97B0", VA = "0x97B0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600493F")]
		[Address(RVA = "0x97B1", Offset = "0x97B1", VA = "0x97B1")]
		private void InstanceListChangedEvent(IList<BossInstance> instances)
		{
		}

		// Token: 0x040027F3 RID: 10227
		[Token(Token = "0x40027F3")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, List<BossInstance>> _instancesByGroupId;
	}
}
