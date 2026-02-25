using System;
using Gameplay.Horde.Events;
using Gameplay.Horde.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Horde.Controller
{
	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x2000702")]
	public class HordeController : AbstractController<HordeModel, HordeEvents>
	{
		// Token: 0x06002AF1 RID: 10993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF1")]
		[Address(RVA = "0x7B8C", Offset = "0x7B8C", VA = "0x7B8C")]
		public HordeController(WorldService worldService, HordeModel model, HordeEvents events)
		{
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0x7B8D", Offset = "0x7B8D", VA = "0x7B8D", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0x7B8E", Offset = "0x7B8E", VA = "0x7B8E")]
		public void GetHordeInfo(bool isCave)
		{
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF4")]
		[Address(RVA = "0x7B8F", Offset = "0x7B8F", VA = "0x7B8F")]
		private void GetHordeInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0x7B90", Offset = "0x7B90", VA = "0x7B90")]
		public void ExitHorde(bool isCave)
		{
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0x7B91", Offset = "0x7B91", VA = "0x7B91")]
		private void ExitHordeResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldService _service;
	}
}
