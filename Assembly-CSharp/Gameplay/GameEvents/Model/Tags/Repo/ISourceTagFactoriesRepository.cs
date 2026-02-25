using System;
using Gameplay.GameEvents.Model.Tags.Factories;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags.Repo
{
	// Token: 0x020007BD RID: 1981
	[Token(Token = "0x20007BD")]
	public interface ISourceTagFactoriesRepository
	{
		// Token: 0x06002EC0 RID: 11968
		[Token(Token = "0x6002EC0")]
		ISourceTagFactory GetFactory(EventTypeDic.Types.SourceTypes id);
	}
}
