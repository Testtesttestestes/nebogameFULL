using System;
using System.Collections;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.Menu.Settings.Model;
using Gameplay.UserInterface.Menu.Settings.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.Settings.Control
{
	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	public class SettingsViewMediator : AbstractViewMediator<SettingsModel, SettingsEvents, SettingsController, SettingsView>
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001734")]
		[Address(RVA = "0x68F3", Offset = "0x68F3", VA = "0x68F3", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x68F4", Offset = "0x68F4", VA = "0x68F4")]
		public SettingsViewMediator(SettingsModel model, SettingsEvents events, SettingsController controller)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000405")]
		public override SettingsView View
		{
			[Token(Token = "0x6001736")]
			[Address(RVA = "0x68F5", Offset = "0x68F5", VA = "0x68F5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x68F6", Offset = "0x68F6", VA = "0x68F6")]
		private void ResetView()
		{
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001738")]
		[Address(RVA = "0x68F7", Offset = "0x68F7", VA = "0x68F7")]
		private void SetView()
		{
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x68F8", Offset = "0x68F8", VA = "0x68F8")]
		private IEnumerator RestartRoutine()
		{
			return null;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x68F9", Offset = "0x68F9", VA = "0x68F9")]
		private void HandleCombatAnimationsEnabled(bool value)
		{
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x68FA", Offset = "0x68FA", VA = "0x68FA")]
		private void HandleCombatSpellAnimationsEnabled(bool value)
		{
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x68FB", Offset = "0x68FB", VA = "0x68FB")]
		private void HandleWorldMovementAnimationsEnabled(bool value)
		{
		}

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x18")]
		private AudioControlViewMediator _audioControlViewMediator;
	}
}
