using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem;

namespace Gameplay.Input
{
	// Token: 0x020006F2 RID: 1778
	[Token(Token = "0x20006F2")]
	public interface IPlayerInput
	{
		// Token: 0x14000158 RID: 344
		// (add) Token: 0x06002A97 RID: 10903
		// (remove) Token: 0x06002A98 RID: 10904
		[Token(Token = "0x14000158")]
		event Action<IPlayerInput, InputAction.CallbackContext> PressEndedEvent;

		// Token: 0x14000159 RID: 345
		// (add) Token: 0x06002A99 RID: 10905
		// (remove) Token: 0x06002A9A RID: 10906
		[Token(Token = "0x14000159")]
		event Action<IPlayerInput, InputAction.CallbackContext> PressStartEvent;

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06002A9B RID: 10907
		[Token(Token = "0x17000814")]
		Pointer CurrentPointer { [Token(Token = "0x6002A9B")] get; }

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06002A9C RID: 10908
		[Token(Token = "0x17000815")]
		bool IsPressed { [Token(Token = "0x6002A9C")] get; }
	}
}
