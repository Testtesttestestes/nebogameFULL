using System;
using System.Collections;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using MVC;
using UnityEngine;
using Utils.CoroutineUtils;

namespace Gameplay.Competition.View.Sections
{
	// Token: 0x020008DC RID: 2268
	[Token(Token = "0x20008DC")]
	[DisallowMultipleComponent]
	public abstract class BaseSectionView<TController> : MonoBehaviour, ISectionView where TController : AbstractController
	{
		// Token: 0x06003560 RID: 13664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003560")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003561")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003562")]
		private static IEnumerator InitializeController(WaitForCallBack awaitInit, TController controller, AbstractMVCEvents controllerEvents)
		{
			return null;
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003563")]
		public void SetController(CompetitionController controller)
		{
		}

		// Token: 0x06003564 RID: 13668
		[Token(Token = "0x6003564")]
		protected abstract void CreateController(CompetitionModel model, CompetitionEvents events, out TController controller);

		// Token: 0x06003565 RID: 13669
		[Token(Token = "0x6003565")]
		protected abstract void CreateMediator(TController controller, out IViewMediator mediator);

		// Token: 0x06003566 RID: 13670
		[Token(Token = "0x6003566")]
		protected abstract void RunController(TController controller, out AbstractMVCEvents events);

		// Token: 0x06003567 RID: 13671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003567")]
		protected BaseSectionView()
		{
		}

		// Token: 0x04001D33 RID: 7475
		[Token(Token = "0x4001D33")]
		[FieldOffset(Offset = "0x0")]
		private IViewMediator _mediator;

		// Token: 0x04001D34 RID: 7476
		[Token(Token = "0x4001D34")]
		[FieldOffset(Offset = "0x0")]
		private TController _sectionController;

		// Token: 0x04001D35 RID: 7477
		[Token(Token = "0x4001D35")]
		[FieldOffset(Offset = "0x0")]
		private AbstractMVCEvents _sectionControllerEvents;

		// Token: 0x04001D36 RID: 7478
		[Token(Token = "0x4001D36")]
		[FieldOffset(Offset = "0x0")]
		private CompetitionController _controller;

		// Token: 0x04001D37 RID: 7479
		[Token(Token = "0x4001D37")]
		[FieldOffset(Offset = "0x0")]
		private readonly WaitForCallBack _awaiterCtrlInit;
	}
}
