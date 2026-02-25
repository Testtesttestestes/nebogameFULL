using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	public interface IGuideTargetResolveEventProvider
	{
		// Token: 0x1400012E RID: 302
		// (add) Token: 0x06001A7D RID: 6781
		// (remove) Token: 0x06001A7E RID: 6782
		[Token(Token = "0x1400012E")]
		event Action<IGuideTargetResolveEventProvider> ResolveEvent;

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001A7F RID: 6783
		[Token(Token = "0x1700049D")]
		GameObject gameObject { [Token(Token = "0x6001A7F")] get; }
	}
}
