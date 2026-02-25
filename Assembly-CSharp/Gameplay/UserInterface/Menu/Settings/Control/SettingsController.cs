using System;
using Gameplay.UserInterface.Menu.Settings.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.Settings.Control
{
	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	public class SettingsController : AbstractController<SettingsModel, SettingsEvents>
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x68EF", Offset = "0x68EF", VA = "0x68EF")]
		public SettingsController(SettingsModel model, SettingsEvents events)
		{
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x68F0", Offset = "0x68F0", VA = "0x68F0")]
		public void SetCombatAnimationsEnabled(bool value)
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x68F1", Offset = "0x68F1", VA = "0x68F1")]
		public void SetCombatSpellAnimationsEnabled(bool value)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x68F2", Offset = "0x68F2", VA = "0x68F2")]
		public void SetWorldMovementAnimationsEnabled(bool value)
		{
		}
	}
}
