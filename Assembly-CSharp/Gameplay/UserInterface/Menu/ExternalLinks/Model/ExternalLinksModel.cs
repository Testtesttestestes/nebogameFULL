using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.UserInterface.Menu.ExternalLinks.Model
{
	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	public class ExternalLinksModel : AbstractModel
	{
		// Token: 0x0600174D RID: 5965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x4887", Offset = "0x4887", VA = "0x4887")]
		public ExternalLinksModel(UserData user, IEnumerable<OptionsMenuButton> buttons)
		{
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700040B")]
		public IReadOnlyList<OptionsMenuButton> Buttons
		{
			[Token(Token = "0x600174E")]
			[Address(RVA = "0x690B", Offset = "0x690B", VA = "0x690B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
