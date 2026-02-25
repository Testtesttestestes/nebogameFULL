using System;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.Isles.Clan.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Clan.Controller
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000CF6")]
	public class ClanIsleGolemViewMediator : AbstractViewMediator<ClanIsleModel, ClanIsleEvents, ClanIsleController, ClanIsleGolemView>
	{
		// Token: 0x060050CA RID: 20682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CA")]
		[Address(RVA = "0x9ED9", Offset = "0x9ED9", VA = "0x9ED9")]
		public ClanIsleGolemViewMediator(ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		}

		// Token: 0x17001054 RID: 4180
		// (set) Token: 0x060050CB RID: 20683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001054")]
		public override ClanIsleEvents Events
		{
			[Token(Token = "0x60050CB")]
			[Address(RVA = "0x9EDA", Offset = "0x9EDA", VA = "0x9EDA", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CC")]
		[Address(RVA = "0x9EDB", Offset = "0x9EDB", VA = "0x9EDB")]
		private void IsCurrentChangedEvent()
		{
		}

		// Token: 0x17001055 RID: 4181
		// (set) Token: 0x060050CD RID: 20685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001055")]
		public override ClanIsleGolemView View
		{
			[Token(Token = "0x60050CD")]
			[Address(RVA = "0x9EDC", Offset = "0x9EDC", VA = "0x9EDC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CE")]
		[Address(RVA = "0x9EDD", Offset = "0x9EDD", VA = "0x9EDD")]
		private void ValidateGolemState()
		{
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CF")]
		[Address(RVA = "0x9EDE", Offset = "0x9EDE", VA = "0x9EDE")]
		private void ViewOnClickEvent()
		{
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D0")]
		[Address(RVA = "0x9EDF", Offset = "0x9EDF", VA = "0x9EDF")]
		private void RenderView()
		{
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D1")]
		[Address(RVA = "0x9EE0", Offset = "0x9EE0", VA = "0x9EE0", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D2")]
		[Address(RVA = "0x9EE1", Offset = "0x9EE1", VA = "0x9EE1")]
		private void GolemStateChangedEvent()
		{
		}
	}
}
