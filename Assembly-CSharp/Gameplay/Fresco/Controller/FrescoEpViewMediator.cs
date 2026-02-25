using System;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Fresco;
using UnityEngine.EventSystems;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	public class FrescoEpViewMediator : AbstractCozyViewMediator<FrescoModel, Gameplay.Fresco.Events.FrescoEvents, FrescoController, FrescoEpView>
	{
		// Token: 0x060030AA RID: 12458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x810F", Offset = "0x810F", VA = "0x810F")]
		public FrescoEpViewMediator(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoController controller)
		{
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x8110", Offset = "0x8110", VA = "0x8110", Slot = "21")]
		protected override void ResetEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x8111", Offset = "0x8111", VA = "0x8111", Slot = "22")]
		protected override void SetupEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x8112", Offset = "0x8112", VA = "0x8112")]
		private void HandleFrescoesUpdatedEvent()
		{
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x8113", Offset = "0x8113", VA = "0x8113")]
		private void HandleFrescoUpdatedEvent(Fresco _)
		{
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x8114", Offset = "0x8114", VA = "0x8114", Slot = "23")]
		protected override void ResetView(FrescoEpView view)
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x8115", Offset = "0x8115", VA = "0x8115", Slot = "24")]
		protected override void SetupView(FrescoEpView view)
		{
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x8116", Offset = "0x8116", VA = "0x8116")]
		private void Init()
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x8117", Offset = "0x8117", VA = "0x8117")]
		private void HandleEpClickEvent(PointerEventData _)
		{
		}
	}
}
