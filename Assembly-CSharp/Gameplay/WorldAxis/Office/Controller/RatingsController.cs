using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	public class RatingsController : AbstractController<RatingsModel, RatingsEvents>
	{
		// Token: 0x06001168 RID: 4456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x6365", Offset = "0x6365", VA = "0x6365")]
		public RatingsController(RatingsModel model, RatingsEvents events, ColossusService service)
		{
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x6366", Offset = "0x6366", VA = "0x6366")]
		public void GetClansRatings()
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x6367", Offset = "0x6367", VA = "0x6367")]
		private void GetClansRatingsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x6368", Offset = "0x6368", VA = "0x6368")]
		public void GetUsersRatings()
		{
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x6369", Offset = "0x6369", VA = "0x6369")]
		private void GetHeroesRatingsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x636A", Offset = "0x636A", VA = "0x636A", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
