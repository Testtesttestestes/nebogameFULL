using System;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001130 RID: 4400
	[Token(Token = "0x2001130")]
	public interface IDictNameSource
	{
		// Token: 0x1400024C RID: 588
		// (add) Token: 0x0600671D RID: 26397
		// (remove) Token: 0x0600671E RID: 26398
		[Token(Token = "0x1400024C")]
		event Action<IDictNameSource> ChangedEvent;

		// Token: 0x0600671F RID: 26399
		[Token(Token = "0x600671F")]
		string GetValue();
	}
}
