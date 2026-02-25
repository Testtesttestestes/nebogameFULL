using System;
using Gameplay.UserInterface.Menu.ExternalLinks.Model;
using Gameplay.UserInterface.Menu.ExternalLinks.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.UserInterface.Menu.ExternalLinks.Control
{
	// Token: 0x020003E7 RID: 999
	[Token(Token = "0x20003E7")]
	public class ExternalLinksMediator : AbstractViewMediator<ExternalLinksModel, ExternalLinksEvents, ExternalLinksController, ExternalLinksView>
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x690D", Offset = "0x690D", VA = "0x690D")]
		public ExternalLinksMediator(ExternalLinksModel model, ExternalLinksEvents events, ExternalLinksController controller)
		{
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001752 RID: 5970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040C")]
		public override ExternalLinksView View
		{
			[Token(Token = "0x6001751")]
			[Address(RVA = "0x690E", Offset = "0x690E", VA = "0x690E", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001752")]
			[Address(RVA = "0x690F", Offset = "0x690F", VA = "0x690F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x6910", Offset = "0x6910", VA = "0x6910")]
		private void OnButtonClick(OptionsMenuButton data)
		{
		}
	}
}
