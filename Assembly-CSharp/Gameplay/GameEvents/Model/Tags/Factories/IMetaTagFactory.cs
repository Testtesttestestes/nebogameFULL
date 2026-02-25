using System;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags.Factories
{
	// Token: 0x020007C0 RID: 1984
	[Token(Token = "0x20007C0")]
	public interface IMetaTagFactory
	{
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002EC9 RID: 11977
		[Token(Token = "0x1700091B")]
		EventTagDic.Types.Tag Id { [Token(Token = "0x6002EC9")] get; }

		// Token: 0x06002ECA RID: 11978
		[Token(Token = "0x6002ECA")]
		AbstractTag Create(IGame game);
	}
}
