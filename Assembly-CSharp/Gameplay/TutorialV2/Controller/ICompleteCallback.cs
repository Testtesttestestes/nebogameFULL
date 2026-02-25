using System;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	public interface ICompleteCallback
	{
		// Token: 0x1400011B RID: 283
		// (add) Token: 0x0600199F RID: 6559
		// (remove) Token: 0x060019A0 RID: 6560
		[Token(Token = "0x1400011B")]
		event Action<ICompleteCallback> CompleteEvent;
	}
}
