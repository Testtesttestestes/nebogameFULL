using System;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Gameplay.GameEvents.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007DF RID: 2015
	[Token(Token = "0x20007DF")]
	public class GameEventReadViewMediator : AbstractViewMediator<GameEventsModel, GameEventsEvents, GameEventsController, GameEventReadView>
	{
		// Token: 0x06002F1E RID: 12062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x7F8B", Offset = "0x7F8B", VA = "0x7F8B", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x7F8C", Offset = "0x7F8C", VA = "0x7F8C")]
		public GameEventReadViewMediator(GameEventsModel model, GameEventsEvents events, GameEventsController controller)
		{
		}

		// Token: 0x17000934 RID: 2356
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000934")]
		public override GameEventReadView View
		{
			[Token(Token = "0x6002F20")]
			[Address(RVA = "0x7F8D", Offset = "0x7F8D", VA = "0x7F8D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000935 RID: 2357
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000935")]
		public override GameEventsEvents Events
		{
			[Token(Token = "0x6002F21")]
			[Address(RVA = "0x7F8E", Offset = "0x7F8E", VA = "0x7F8E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F22")]
		[Address(RVA = "0x7F8F", Offset = "0x7F8F", VA = "0x7F8F")]
		private void HandleOnActionTriggeredEvent(object sender, AbstractActionOnEvent action)
		{
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F23")]
		[Address(RVA = "0x7F90", Offset = "0x7F90", VA = "0x7F90")]
		private void HandleOnDropProcessCompleteEvent()
		{
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x7F91", Offset = "0x7F91", VA = "0x7F91")]
		private void HandleOnClickTakeRewardButton()
		{
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x7F92", Offset = "0x7F92", VA = "0x7F92")]
		private void HandleClickOnBackground(PointerEventData obj)
		{
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x7F93", Offset = "0x7F93", VA = "0x7F93")]
		private void HandleGetRewardCompleteEvent(GameEventData evt)
		{
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x7F94", Offset = "0x7F94", VA = "0x7F94")]
		private void DisplayArtifactReward(GameEventData evt)
		{
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F28")]
		[Address(RVA = "0x7F95", Offset = "0x7F95", VA = "0x7F95")]
		private void HandleGetReward()
		{
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F29")]
		[Address(RVA = "0x7F96", Offset = "0x7F96", VA = "0x7F96")]
		private void SetupView()
		{
		}
	}
}
