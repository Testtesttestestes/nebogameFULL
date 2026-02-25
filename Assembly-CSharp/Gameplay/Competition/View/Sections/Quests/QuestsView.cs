using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control.Sections;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Competition.View.Sections.Quests
{
	// Token: 0x020008E7 RID: 2279
	[Token(Token = "0x20008E7")]
	[AddComponentMenu("Competition/View/Sections/QuestsView")]
	public class QuestsView : BaseSectionView<QuestController>
	{
		// Token: 0x14000172 RID: 370
		// (add) Token: 0x060035B5 RID: 13749 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060035B6 RID: 13750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000172")]
		public event Action<IDailyQuest> ItemSelectedEvent
		{
			[Token(Token = "0x60035B5")]
			[Address(RVA = "0x85C3", Offset = "0x85C3", VA = "0x85C3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60035B6")]
			[Address(RVA = "0x85C4", Offset = "0x85C4", VA = "0x85C4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x85C5", Offset = "0x85C5", VA = "0x85C5", Slot = "6")]
		protected override void CreateController(CompetitionModel model, CompetitionEvents events, out QuestController controller)
		{
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x85C6", Offset = "0x85C6", VA = "0x85C6", Slot = "7")]
		protected override void CreateMediator(QuestController controller, out IViewMediator mediator)
		{
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x85C7", Offset = "0x85C7", VA = "0x85C7", Slot = "8")]
		protected override void RunController(QuestController controller, out AbstractMVCEvents events)
		{
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x85C8", Offset = "0x85C8", VA = "0x85C8")]
		public void Init(IList<DailyQuestsListElementArgs> items)
		{
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x85C9", Offset = "0x85C9", VA = "0x85C9")]
		public QuestsView()
		{
		}

		// Token: 0x04001D61 RID: 7521
		[Token(Token = "0x4001D61")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DailyQuestsListAdapter _questsListAdapter;
	}
}
