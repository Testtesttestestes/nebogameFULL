using System;
using DG.Tweening;
using Gameplay.WorldAxis.Controller;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	public class WorldAxisOfficeController : AbstractController<WorldAxisOfficeModel, WorldAxisOfficeEvents>
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x6386", Offset = "0x6386", VA = "0x6386")]
		public WorldAxisOfficeController(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisController worldAxisController)
		{
		}

		// Token: 0x17000296 RID: 662
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000296")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x600118A")]
			[Address(RVA = "0x6387", Offset = "0x6387", VA = "0x6387", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x6388", Offset = "0x6388", VA = "0x6388", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x6389", Offset = "0x6389", VA = "0x6389", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x638A", Offset = "0x638A", VA = "0x638A")]
		private void RepopulateSchedule()
		{
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x638B", Offset = "0x638B", VA = "0x638B")]
		private void UpdateSchedule()
		{
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x638C", Offset = "0x638C", VA = "0x638C")]
		public void GetColossusRating(uint colossusId)
		{
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x638D", Offset = "0x638D", VA = "0x638D")]
		private void GetColossusRatingResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001191")]
		[Address(RVA = "0x638E", Offset = "0x638E", VA = "0x638E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldAxisController _worldAxisController;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x1C")]
		private ColossusService _service;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x20")]
		private Tween _timer;
	}
}
