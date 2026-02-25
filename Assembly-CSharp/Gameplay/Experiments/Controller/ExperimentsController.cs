using System;
using Gameplay.Experiments.Events;
using Gameplay.Experiments.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Experiments.Controller
{
	// Token: 0x0200082D RID: 2093
	[Token(Token = "0x200082D")]
	public class ExperimentsController : AbstractController<ExperimentsModel, ExperimentsEvents>
	{
		// Token: 0x06003149 RID: 12617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x81A1", Offset = "0x81A1", VA = "0x81A1")]
		public ExperimentsController(ExperimentsModel model, ExperimentsEvents events)
		{
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x81A2", Offset = "0x81A2", VA = "0x81A2", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x81A3", Offset = "0x81A3", VA = "0x81A3", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314C")]
		[Address(RVA = "0x81A4", Offset = "0x81A4", VA = "0x81A4")]
		private void GetUserExperiments()
		{
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314D")]
		[Address(RVA = "0x81A5", Offset = "0x81A5", VA = "0x81A5")]
		private void HandleGetUserExperiments(OpToken<IMessage, object> opToken)
		{
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314E")]
		[Address(RVA = "0x81A6", Offset = "0x81A6", VA = "0x81A6")]
		private void ValidateInit()
		{
		}

		// Token: 0x04001AE8 RID: 6888
		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;
	}
}
