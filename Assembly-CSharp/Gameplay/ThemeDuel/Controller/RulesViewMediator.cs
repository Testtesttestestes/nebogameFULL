using System;
using System.Collections;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View.RulesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using UnityEngine;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004EB RID: 1259
	[Token(Token = "0x20004EB")]
	public class RulesViewMediator : AbstractViewMediator<ThemeDuelModel, ThemeDuelEvents, ThemeDuelController, RulesView>, IHideableMediator
	{
		// Token: 0x06001E07 RID: 7687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x6F85", Offset = "0x6F85", VA = "0x6F85")]
		public RulesViewMediator(ThemeDuelModel model, ThemeDuelEvents events, ThemeDuelController controller)
		{
		}

		// Token: 0x17000576 RID: 1398
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000576")]
		public override RulesView View
		{
			[Token(Token = "0x6001E08")]
			[Address(RVA = "0x6F86", Offset = "0x6F86", VA = "0x6F86", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x6F87", Offset = "0x6F87", VA = "0x6F87")]
		private void InShieldButtonClickedEventHandler()
		{
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x6F88", Offset = "0x6F88", VA = "0x6F88")]
		private void HandleHandBookClickEvent()
		{
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x6F89", Offset = "0x6F89", VA = "0x6F89")]
		private void ResetView()
		{
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0x6F8A", Offset = "0x6F8A", VA = "0x6F8A")]
		private void SetupView()
		{
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x6F8B", Offset = "0x6F8B", VA = "0x6F8B")]
		private IEnumerator DuelFinishedRoutine(float backTime)
		{
			return null;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x6F8C", Offset = "0x6F8C", VA = "0x6F8C", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _duelFinishedRoutine;
	}
}
