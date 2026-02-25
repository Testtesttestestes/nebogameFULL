using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Services;

namespace Core.Gameplay.Managers.Ad.Placements
{
	// Token: 0x0200120A RID: 4618
	[Token(Token = "0x200120A")]
	public interface IAdPlacementData : IDisposable
	{
		// Token: 0x140002DC RID: 732
		// (add) Token: 0x06006D99 RID: 28057
		// (remove) Token: 0x06006D9A RID: 28058
		[Token(Token = "0x140002DC")]
		event Action<IAdPlacementData> BackTimerCompleteEvent;

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06006D9B RID: 28059
		[Token(Token = "0x17001648")]
		uint AdPlacementId { [Token(Token = "0x6006D9B")] get; }

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06006D9C RID: 28060
		[Token(Token = "0x17001649")]
		string Name { [Token(Token = "0x6006D9C")] get; }

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06006D9D RID: 28061
		[Token(Token = "0x1700164A")]
		bool IsAvailableByAppServer { [Token(Token = "0x6006D9D")] get; }

		// Token: 0x06006D9E RID: 28062
		[Token(Token = "0x6006D9E")]
		void SetInfo([NotNull] AdPlacementInfo value);
	}
}
