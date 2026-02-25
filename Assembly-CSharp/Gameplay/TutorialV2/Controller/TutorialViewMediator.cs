using System;
using System.Collections.Generic;
using Gameplay.TutorialV2.Events;
using Gameplay.TutorialV2.Model;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	public class TutorialViewMediator : AbstractViewMediator<TutorialModel, TutorialEvents, TutorialController, TutorialView>
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x6B3F", Offset = "0x6B3F", VA = "0x6B3F", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x6B40", Offset = "0x6B40", VA = "0x6B40")]
		public TutorialViewMediator(TutorialModel model, TutorialEvents events, TutorialController controller)
		{
		}

		// Token: 0x17000487 RID: 1159
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000487")]
		public override TutorialEvents Events
		{
			[Token(Token = "0x60019A9")]
			[Address(RVA = "0x6B41", Offset = "0x6B41", VA = "0x6B41", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000488")]
		public override TutorialView View
		{
			[Token(Token = "0x60019AA")]
			[Address(RVA = "0x6B42", Offset = "0x6B42", VA = "0x6B42", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x6B43", Offset = "0x6B43", VA = "0x6B43")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x6B44", Offset = "0x6B44", VA = "0x6B44")]
		private void StartCombat()
		{
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x6B45", Offset = "0x6B45", VA = "0x6B45")]
		private void HandleRequestPrepareCombatView()
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x6B46", Offset = "0x6B46", VA = "0x6B46")]
		private void HandleRequestPrepareGuideView()
		{
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x6B47", Offset = "0x6B47", VA = "0x6B47")]
		private void HandleCombatCompleteEvent()
		{
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x6B48", Offset = "0x6B48", VA = "0x6B48")]
		private void HandleTutorialScreenClickEvent(PointerEventData data)
		{
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x6B49", Offset = "0x6B49", VA = "0x6B49")]
		private void StartCombatButtonClickedEventHandler()
		{
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x6B4A", Offset = "0x6B4A", VA = "0x6B4A")]
		private void ResetView()
		{
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x6B4B", Offset = "0x6B4B", VA = "0x6B4B")]
		private void SetupView()
		{
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x6B4C", Offset = "0x6B4C", VA = "0x6B4C")]
		private void OnRegistrationComplete()
		{
		}

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<IDisposable> _toDispose;
	}
}
