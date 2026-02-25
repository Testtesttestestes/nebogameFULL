using System;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.Combat.Control
{
	// Token: 0x020009B4 RID: 2484
	[Token(Token = "0x20009B4")]
	public abstract class AbstractOneOnOneCombatViewMediator<TModel, TEvents, TController, TView> : AbstractCombatViewMediator<TModel, TEvents, TController, TView> where TModel : CombatModel where TEvents : CombatEvents where TController : CombatController<TModel, TEvents> where TView : OneOnOneCombatView
	{
		// Token: 0x06003B54 RID: 15188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B54")]
		public AbstractOneOnOneCombatViewMediator(TModel model, TEvents events, TController controller)
		{
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B55")]
		protected override void HandleInitEvent()
		{
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B56")]
		private void HandleChatEvent(CombatPlayer player, string text)
		{
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B57")]
		protected virtual void UpdateExperience()
		{
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B58")]
		protected override void HandleOtherPlayerTriggersChangedEvent(ulong userId)
		{
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B59")]
		protected override void AddGameProcessEventsHandlers()
		{
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B5A")]
		protected override void RemoveGameProcessEventsHandlers()
		{
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B5B")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B5C")]
		protected override void HandleResetView()
		{
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B5D")]
		protected override void HandleSetupView()
		{
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B5E")]
		private void HandleSkillInfoVisibleLeft(bool isVisible)
		{
		}
	}
}
