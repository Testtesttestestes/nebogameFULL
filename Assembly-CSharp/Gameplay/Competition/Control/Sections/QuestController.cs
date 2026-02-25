using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x02000907 RID: 2311
	[Token(Token = "0x2000907")]
	public class QuestController : AbstractController<QuestModel, QuestEvents>
	{
		// Token: 0x06003657 RID: 13911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x8664", Offset = "0x8664", VA = "0x8664")]
		public QuestController(QuestModel model, QuestEvents events)
		{
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x8665", Offset = "0x8665", VA = "0x8665", Slot = "7")]
		protected override void HandleRun()
		{
		}
	}
}
