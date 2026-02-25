using System;
using System.Collections.Generic;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.Sections.Quests;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x02000908 RID: 2312
	[Token(Token = "0x2000908")]
	public class QuestsViewMediator : AbstractCozyViewMediator<QuestModel, QuestEvents, QuestController, QuestsView>
	{
		// Token: 0x06003659 RID: 13913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x8666", Offset = "0x8666", VA = "0x8666")]
		public QuestsViewMediator(QuestsView view, QuestModel model, QuestEvents events, QuestController controller)
		{
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x8667", Offset = "0x8667", VA = "0x8667", Slot = "21")]
		protected override void ResetEvents(QuestEvents events)
		{
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x8668", Offset = "0x8668", VA = "0x8668", Slot = "22")]
		protected override void SetupEvents(QuestEvents events)
		{
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x8669", Offset = "0x8669", VA = "0x8669", Slot = "23")]
		protected override void ResetView(QuestsView view)
		{
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x866A", Offset = "0x866A", VA = "0x866A", Slot = "24")]
		protected override void SetupView(QuestsView view)
		{
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365E")]
		[Address(RVA = "0x866B", Offset = "0x866B", VA = "0x866B")]
		private void HandleItemSelectedEvent(IQuest quest)
		{
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x866C", Offset = "0x866C", VA = "0x866C")]
		private void DisplayData()
		{
		}

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[FieldOffset(Offset = "0x18")]
		private readonly IComparer<IQuest> _questComparer;
	}
}
