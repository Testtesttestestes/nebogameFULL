using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.GdEvents.Control.EventSections
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public class DescriptionViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, DescriptionEventSectionView>
	{
		// Token: 0x06002D36 RID: 11574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x7DB4", Offset = "0x7DB4", VA = "0x7DB4")]
		public DescriptionViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		}

		// Token: 0x170008B2 RID: 2226
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B2")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D37")]
			[Address(RVA = "0x7DB5", Offset = "0x7DB5", VA = "0x7DB5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x7DB6", Offset = "0x7DB6", VA = "0x7DB6")]
		private void InventoryChangedEventHandler()
		{
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x7DB7", Offset = "0x7DB7", VA = "0x7DB7")]
		private void HandleCurrentEventRewardUpdatedEvent(GdEventData evt)
		{
		}

		// Token: 0x170008B3 RID: 2227
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B3")]
		public override DescriptionEventSectionView View
		{
			[Token(Token = "0x6002D3A")]
			[Address(RVA = "0x7DB8", Offset = "0x7DB8", VA = "0x7DB8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0x7DB9", Offset = "0x7DB9", VA = "0x7DB9")]
		private void ResetView()
		{
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x7DBA", Offset = "0x7DBA", VA = "0x7DBA")]
		private void SetupView()
		{
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x7DBB", Offset = "0x7DBB", VA = "0x7DBB")]
		private void AprsButtonClickedEventHandler()
		{
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x7DBC", Offset = "0x7DBC", VA = "0x7DBC")]
		private void MedalsButtonClickedEventHandler()
		{
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x7DBD", Offset = "0x7DBD", VA = "0x7DBD")]
		private void CollectionsButtonClickedEventHandler()
		{
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x7DBE", Offset = "0x7DBE", VA = "0x7DBE")]
		private void ItemsButtonClickedEventHandler()
		{
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x7DBF", Offset = "0x7DBF", VA = "0x7DBF")]
		private bool TryGetContentFromMilestones(Func<GameEventDic.Types.Milestone, IEnumerable<uint>> getter, out HashSet<uint> result)
		{
			return default(bool);
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x7DC0", Offset = "0x7DC0", VA = "0x7DC0")]
		private void HandleRewards(GdEventData evt)
		{
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x7DC1", Offset = "0x7DC1", VA = "0x7DC1")]
		private bool TryShowRewards(RewardData[] rewards)
		{
			return default(bool);
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x7DC2", Offset = "0x7DC2", VA = "0x7DC2")]
		private void HandleBattlePass()
		{
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D45")]
		[Address(RVA = "0x7DC3", Offset = "0x7DC3", VA = "0x7DC3")]
		[CompilerGenerated]
		private List<uint> <HandleBattlePass>g__GetAvailableOptions|16_1()
		{
			return null;
		}
	}
}
