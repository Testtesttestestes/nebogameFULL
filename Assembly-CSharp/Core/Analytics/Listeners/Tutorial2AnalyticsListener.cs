using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012E4 RID: 4836
	[Token(Token = "0x20012E4")]
	public class Tutorial2AnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001746")]
		protected override string Theme
		{
			[Token(Token = "0x600730A")]
			[Address(RVA = "0xBD13", Offset = "0xBD13", VA = "0xBD13", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730B")]
		[Address(RVA = "0xBD14", Offset = "0xBD14", VA = "0xBD14", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730C")]
		[Address(RVA = "0xBD15", Offset = "0xBD15", VA = "0xBD15", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730D")]
		[Address(RVA = "0xBD16", Offset = "0xBD16", VA = "0xBD16")]
		private void UseElixirEvent(CombatScope.UseSpellArgs e)
		{
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730E")]
		[Address(RVA = "0xBD17", Offset = "0xBD17", VA = "0xBD17")]
		private void UseSpellEvent(CombatScope.UseSpellArgs e)
		{
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600730F")]
		[Address(RVA = "0xBD18", Offset = "0xBD18", VA = "0xBD18")]
		private void ComboEvent(CombatScope.ComboEventArgs e)
		{
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007310")]
		[Address(RVA = "0xBD19", Offset = "0xBD19", VA = "0xBD19")]
		private void TutorialStepFinishEvent(Tutorial2Scope.Tutorial2StepEventArgs e)
		{
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007311")]
		[Address(RVA = "0xBD1A", Offset = "0xBD1A", VA = "0xBD1A")]
		private void TutorialStepStartEvent(Tutorial2Scope.Tutorial2StepEventArgs e)
		{
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007312")]
		[Address(RVA = "0xBD1B", Offset = "0xBD1B", VA = "0xBD1B")]
		public Tutorial2AnalyticsListener()
		{
		}

		// Token: 0x04003C3B RID: 15419
		[Token(Token = "0x4003C3B")]
		public const string THEME = "tutorial_details";

		// Token: 0x04003C3C RID: 15420
		[Token(Token = "0x4003C3C")]
		public const string TUTORIAL2_STEP_START = "step_start";

		// Token: 0x04003C3D RID: 15421
		[Token(Token = "0x4003C3D")]
		public const string TUTORIAL2_STEP_FINISH = "step_finish";

		// Token: 0x04003C3E RID: 15422
		[Token(Token = "0x4003C3E")]
		public const string COMBAT_COMBO = "combat_combo";

		// Token: 0x04003C3F RID: 15423
		[Token(Token = "0x4003C3F")]
		public const string USE_SPELL = "use_spell";

		// Token: 0x04003C40 RID: 15424
		[Token(Token = "0x4003C40")]
		public const string USE_ELIXIR = "use_elixir";
	}
}
