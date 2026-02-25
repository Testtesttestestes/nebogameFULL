using System;
using System.Collections.Generic;
using Gameplay.GameEvents.Model.Tags.Factories;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags.Repo
{
	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x20007BC")]
	public interface IMetaTagFactoriesRepository
	{
		// Token: 0x06002EBE RID: 11966
		[Token(Token = "0x6002EBE")]
		bool TryGetFactory(EventTagDic.Types.Tag id, out IMetaTagFactory factory);

		// Token: 0x06002EBF RID: 11967
		[Token(Token = "0x6002EBF")]
		bool TryGetFactory(EventTagDic.Types.Tag[] ids, out List<IMetaTagFactory> factories);
	}
}
