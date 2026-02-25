using System;
using System.Collections.Generic;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x0200088B RID: 2187
	[Token(Token = "0x200088B")]
	public class DailyQuestsViewMediator : AbstractViewMediator<DailyQuestsModel, DailyQuestEvents, DailyQuestsController, DailyQuestsView>
	{
		// Token: 0x0600339B RID: 13211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x83D5", Offset = "0x83D5", VA = "0x83D5")]
		public DailyQuestsViewMediator(DailyQuestsModel model, DailyQuestEvents events, DailyQuestsController controller, uint categoryToShow)
		{
		}

		// Token: 0x17000A41 RID: 2625
		// (set) Token: 0x0600339C RID: 13212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A41")]
		public override DailyQuestEvents Events
		{
			[Token(Token = "0x600339C")]
			[Address(RVA = "0x83D6", Offset = "0x83D6", VA = "0x83D6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A42")]
		public override DailyQuestsView View
		{
			[Token(Token = "0x600339D")]
			[Address(RVA = "0x83D7", Offset = "0x83D7", VA = "0x83D7", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339E")]
		[Address(RVA = "0x83D8", Offset = "0x83D8", VA = "0x83D8")]
		private void HandleQuestsUpdated()
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339F")]
		[Address(RVA = "0x83D9", Offset = "0x83D9", VA = "0x83D9")]
		private void HandleActiveQuestsCountChanged()
		{
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x83DA", Offset = "0x83DA", VA = "0x83DA")]
		private void HandleSetupView()
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x83DB", Offset = "0x83DB", VA = "0x83DB")]
		private int GetIndex(TabBarItemData<DailyQuestCategoriesDic>[] data)
		{
			return 0;
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x83DC", Offset = "0x83DC", VA = "0x83DC")]
		private int GetFirstSortTabIndex(TabBarItemData<DailyQuestCategoriesDic>[] data, List<DailyQuestCategoriesDic> list)
		{
			return 0;
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x83DD", Offset = "0x83DD", VA = "0x83DD")]
		private void DisplayData(uint categoryId)
		{
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A4")]
		[Address(RVA = "0x83DE", Offset = "0x83DE", VA = "0x83DE")]
		private void HandleItemClick(IQuest data)
		{
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x83DF", Offset = "0x83DF", VA = "0x83DF")]
		private void ValidateTabCounters()
		{
		}

		// Token: 0x04001C18 RID: 7192
		[Token(Token = "0x4001C18")]
		[FieldOffset(Offset = "0x18")]
		private uint _currentCategory;

		// Token: 0x04001C19 RID: 7193
		[Token(Token = "0x4001C19")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IComparer<IQuest> _questComparer;
	}
}
