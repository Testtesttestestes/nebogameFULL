using System;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x02000887 RID: 2183
	[Token(Token = "0x2000887")]
	public class DailyQuestReadViewMediator : AbstractViewMediator<DailyQuestsModel, DailyQuestEvents, DailyQuestsController, DailyQuestReadView>
	{
		// Token: 0x0600335C RID: 13148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335C")]
		[Address(RVA = "0x8397", Offset = "0x8397", VA = "0x8397", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335D")]
		[Address(RVA = "0x8398", Offset = "0x8398", VA = "0x8398")]
		public DailyQuestReadViewMediator(DailyQuestsModel model, DailyQuestEvents events, DailyQuestsController controller)
		{
		}

		// Token: 0x17000A3D RID: 2621
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3D")]
		public override DailyQuestReadView View
		{
			[Token(Token = "0x600335E")]
			[Address(RVA = "0x8399", Offset = "0x8399", VA = "0x8399", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3E")]
		public override DailyQuestEvents Events
		{
			[Token(Token = "0x600335F")]
			[Address(RVA = "0x839A", Offset = "0x839A", VA = "0x839A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003360")]
		[Address(RVA = "0x839B", Offset = "0x839B", VA = "0x839B")]
		private void ToMailButtonClickedEventHandler()
		{
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003361")]
		[Address(RVA = "0x839C", Offset = "0x839C", VA = "0x839C")]
		private void ActionButtonClickedEventHandler()
		{
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003362")]
		[Address(RVA = "0x839D", Offset = "0x839D", VA = "0x839D")]
		private void HandleTakeRewardFinishedEvent()
		{
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003363")]
		[Address(RVA = "0x839E", Offset = "0x839E", VA = "0x839E")]
		private void ShowTutorial()
		{
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003364")]
		[Address(RVA = "0x839F", Offset = "0x839F", VA = "0x839F")]
		private void TakeDailyQuestReward()
		{
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003365")]
		[Address(RVA = "0x83A0", Offset = "0x83A0", VA = "0x83A0")]
		private void TakeGoalReward()
		{
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003366")]
		[Address(RVA = "0x83A1", Offset = "0x83A1", VA = "0x83A1")]
		private void QuestChangedEventHandler()
		{
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003367")]
		[Address(RVA = "0x83A2", Offset = "0x83A2", VA = "0x83A2")]
		private void ResetView()
		{
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003368")]
		[Address(RVA = "0x83A3", Offset = "0x83A3", VA = "0x83A3")]
		private void SetupView()
		{
		}

		// Token: 0x04001C0A RID: 7178
		[Token(Token = "0x4001C0A")]
		[FieldOffset(Offset = "0x18")]
		private Action ActionHandler;

		// Token: 0x04001C0B RID: 7179
		[Token(Token = "0x4001C0B")]
		[FieldOffset(Offset = "0x1C")]
		private IQuest _currentQuest;
	}
}
