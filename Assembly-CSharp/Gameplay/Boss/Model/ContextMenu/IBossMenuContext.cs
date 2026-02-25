using System;
using Il2CppDummyDll;
using UI.UserContextMenu;

namespace Gameplay.Boss.Model.ContextMenu
{
	// Token: 0x02000B9C RID: 2972
	[Token(Token = "0x2000B9C")]
	public interface IBossMenuContext : IUserMenuContext
	{
		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x060048B4 RID: 18612
		// (set) Token: 0x060048B5 RID: 18613
		[Token(Token = "0x17000ED2")]
		TeamData.AbstractTeamMember TeamMemberData { [Token(Token = "0x60048B4")] get; [Token(Token = "0x60048B5")] set; }
	}
}
