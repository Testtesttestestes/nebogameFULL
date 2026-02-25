using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.UserInterface.Menu.ExternalLinks.View
{
	// Token: 0x020003E3 RID: 995
	[Token(Token = "0x20003E3")]
	public class ExternalLinksEvents : AbstractMVCEvents
	{
		// Token: 0x06001749 RID: 5961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x6907", Offset = "0x6907", VA = "0x6907")]
		public ExternalLinksEvents()
		{
		}

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x14")]
		public Action<OptionsMenuButton> ClickExternalLinkEvent;
	}
}
