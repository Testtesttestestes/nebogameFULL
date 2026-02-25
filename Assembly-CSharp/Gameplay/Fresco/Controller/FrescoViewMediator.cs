using System;
using Core.Data;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Fresco;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	public class FrescoViewMediator : AbstractCozyViewMediator<FrescoModel, Gameplay.Fresco.Events.FrescoEvents, FrescoController, FrescoView>
	{
		// Token: 0x060030B3 RID: 12467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x8118", Offset = "0x8118", VA = "0x8118")]
		public FrescoViewMediator(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoController controller, UserData owner)
		{
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B4")]
		[Address(RVA = "0x8119", Offset = "0x8119", VA = "0x8119", Slot = "21")]
		protected override void ResetEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x811A", Offset = "0x811A", VA = "0x811A", Slot = "22")]
		protected override void SetupEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B6")]
		[Address(RVA = "0x811B", Offset = "0x811B", VA = "0x811B", Slot = "23")]
		protected override void ResetView(FrescoView view)
		{
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B7")]
		[Address(RVA = "0x811C", Offset = "0x811C", VA = "0x811C", Slot = "24")]
		protected override void SetupView(FrescoView view)
		{
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B8")]
		[Address(RVA = "0x811D", Offset = "0x811D", VA = "0x811D")]
		private void InitView()
		{
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x811E", Offset = "0x811E", VA = "0x811E")]
		private void FillClickHandler()
		{
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x811F", Offset = "0x811F", VA = "0x811F")]
		private void CollectionsButtonClickHandler()
		{
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x8120", Offset = "0x8120", VA = "0x8120")]
		private void OnFrescoClickHandler(ulong frescoId)
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BC")]
		[Address(RVA = "0x8121", Offset = "0x8121", VA = "0x8121")]
		private void FrescoesUpdatedHandler()
		{
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BD")]
		[Address(RVA = "0x8122", Offset = "0x8122", VA = "0x8122")]
		private void FrescoUpdatedHandler(Fresco _)
		{
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BE")]
		[Address(RVA = "0x8123", Offset = "0x8123", VA = "0x8123")]
		private void OtherFrescoesUpdatedHandler()
		{
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BF")]
		[Address(RVA = "0x8124", Offset = "0x8124", VA = "0x8124")]
		private void HandleTabBarChangeEvent()
		{
		}
	}
}
