using System;
using Gameplay.Announcements.Model;
using Gameplay.Announcements.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Announcements.Control
{
	// Token: 0x02000DA8 RID: 3496
	[Token(Token = "0x2000DA8")]
	public class AnnouncementsViewMediator : AbstractViewMediator<AnnouncementsModel, AnnouncementsEvents, AnnouncementsController, AnnouncementsView>
	{
		// Token: 0x06005577 RID: 21879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005577")]
		[Address(RVA = "0xA317", Offset = "0xA317", VA = "0xA317")]
		public AnnouncementsViewMediator(AnnouncementsModel model, AnnouncementsEvents events, AnnouncementsController controller)
		{
		}

		// Token: 0x1700115A RID: 4442
		// (set) Token: 0x06005578 RID: 21880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700115A")]
		public override AnnouncementsView View
		{
			[Token(Token = "0x6005578")]
			[Address(RVA = "0xA318", Offset = "0xA318", VA = "0xA318", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005579")]
		[Address(RVA = "0xA319", Offset = "0xA319", VA = "0xA319")]
		private void ResetView()
		{
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557A")]
		[Address(RVA = "0xA31A", Offset = "0xA31A", VA = "0xA31A")]
		private void SetupView()
		{
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557B")]
		[Address(RVA = "0xA31B", Offset = "0xA31B", VA = "0xA31B")]
		private void HandleActivityButtonClickEvent()
		{
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557C")]
		[Address(RVA = "0xA31C", Offset = "0xA31C", VA = "0xA31C")]
		private void HandleAnnouncementActivity(AnnouncementsData announcement)
		{
		}
	}
}
