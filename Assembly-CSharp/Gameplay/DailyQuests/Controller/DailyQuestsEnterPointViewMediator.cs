using System;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x0200088A RID: 2186
	[Token(Token = "0x200088A")]
	public class DailyQuestsEnterPointViewMediator : AbstractViewMediator<DailyQuestsModel, DailyQuestEvents, DailyQuestsController, UserInterfaceView>
	{
		// Token: 0x0600338F RID: 13199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x83C9", Offset = "0x83C9", VA = "0x83C9")]
		public DailyQuestsEnterPointViewMediator(DailyQuestsModel model, DailyQuestEvents events, DailyQuestsController controller)
		{
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003390")]
		[Address(RVA = "0x83CA", Offset = "0x83CA", VA = "0x83CA", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x17000A3F RID: 2623
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3F")]
		public override DailyQuestEvents Events
		{
			[Token(Token = "0x6003391")]
			[Address(RVA = "0x83CB", Offset = "0x83CB", VA = "0x83CB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (set) Token: 0x06003392 RID: 13202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A40")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6003392")]
			[Address(RVA = "0x83CC", Offset = "0x83CC", VA = "0x83CC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003393")]
		[Address(RVA = "0x83CD", Offset = "0x83CD", VA = "0x83CD")]
		private void SetupView()
		{
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x83CE", Offset = "0x83CE", VA = "0x83CE")]
		private void HandleActiveQuestsCountChanged()
		{
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003395")]
		[Address(RVA = "0x83CF", Offset = "0x83CF", VA = "0x83CF")]
		private void TryShowNotification()
		{
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x83D0", Offset = "0x83D0", VA = "0x83D0")]
		private void HandleDailyQuestsButtonClickedEvent(IndexButtonBasic btn)
		{
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x83D1", Offset = "0x83D1", VA = "0x83D1")]
		private void HandleQuestsChangedEvent()
		{
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003398")]
		[Address(RVA = "0x83D2", Offset = "0x83D2", VA = "0x83D2")]
		private void ShowDailyQuests()
		{
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x83D3", Offset = "0x83D3", VA = "0x83D3")]
		private void CloseDailyQuests()
		{
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339A")]
		[Address(RVA = "0x83D4", Offset = "0x83D4", VA = "0x83D4")]
		private void HandleOnCloseDailyQuestsWindow()
		{
		}

		// Token: 0x04001C17 RID: 7191
		[Token(Token = "0x4001C17")]
		[FieldOffset(Offset = "0x18")]
		private DailyQuestsWindow _dailyQuestsWindow;
	}
}
