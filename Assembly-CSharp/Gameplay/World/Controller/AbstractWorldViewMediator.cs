using System;
using CloudsFly.Movement;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Gameplay.World.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.World.Controller
{
	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	public abstract class AbstractWorldViewMediator : AbstractViewMediator<WorldModel, WorldControllerEvents, WorldController, WorldView>
	{
		// Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x6661", Offset = "0x6661", VA = "0x6661")]
		public AbstractWorldViewMediator(WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		}

		// Token: 0x17000362 RID: 866
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public override WorldView View
		{
			[Token(Token = "0x6001498")]
			[Address(RVA = "0x6662", Offset = "0x6662", VA = "0x6662", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x6663", Offset = "0x6663", VA = "0x6663")]
		private void ViewOnMovCompleteEvent(WorldMovementTypes type)
		{
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x6664", Offset = "0x6664", VA = "0x6664")]
		private void ViewOnMovStartEvent(WorldMovementTypes type)
		{
		}

		// Token: 0x0600149B RID: 5275
		[Token(Token = "0x600149B")]
		public abstract void Clear();

		// Token: 0x0600149C RID: 5276
		[Token(Token = "0x600149C")]
		protected abstract void StartMovement();

		// Token: 0x0600149D RID: 5277
		[Token(Token = "0x600149D")]
		protected abstract void CompleteMovement();
	}
}
