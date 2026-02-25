using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Aprs.Controller
{
	// Token: 0x02000D72 RID: 3442
	[Token(Token = "0x2000D72")]
	public class AprsController : AbstractController<AprsModel, AprsEvents>
	{
		// Token: 0x06005455 RID: 21589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005455")]
		[Address(RVA = "0xA20B", Offset = "0xA20B", VA = "0xA20B", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005456")]
		[Address(RVA = "0xA20C", Offset = "0xA20C", VA = "0xA20C")]
		public AprsController(AprsModel model, AprsEvents events)
		{
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005457")]
		[Address(RVA = "0xA20D", Offset = "0xA20D", VA = "0xA20D", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005458")]
		[Address(RVA = "0xA20E", Offset = "0xA20E", VA = "0xA20E", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005459")]
		[Address(RVA = "0xA20F", Offset = "0xA20F", VA = "0xA20F")]
		private void HandleDictProviderChangedEvent()
		{
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545A")]
		[Address(RVA = "0xA210", Offset = "0xA210", VA = "0xA210")]
		private void UserOnOnUserGenderChangedEvent()
		{
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545B")]
		[Address(RVA = "0xA211", Offset = "0xA211", VA = "0xA211")]
		private void UserOnOnUserCultChangedEvent(CultDic obj)
		{
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545C")]
		[Address(RVA = "0xA212", Offset = "0xA212", VA = "0xA212")]
		public void ApplyApr(uint medalId)
		{
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545D")]
		[Address(RVA = "0xA213", Offset = "0xA213", VA = "0xA213")]
		private void HandleApplyAprService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545E")]
		[Address(RVA = "0xA214", Offset = "0xA214", VA = "0xA214")]
		private void MedalBuyEvent(MedalInfo medalInfo)
		{
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545F")]
		[Address(RVA = "0xA215", Offset = "0xA215", VA = "0xA215")]
		private void MedalAddedEvent(MedalInfo medalInfo)
		{
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005460")]
		[Address(RVA = "0xA216", Offset = "0xA216", VA = "0xA216")]
		private void MedalRemovedEvent(uint medalId)
		{
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005461")]
		[Address(RVA = "0xA217", Offset = "0xA217", VA = "0xA217")]
		private void UserCacheResultCallback(long operationIndex, params UserData[] data)
		{
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005462")]
		[Address(RVA = "0xA218", Offset = "0xA218", VA = "0xA218")]
		private void ValidateInit()
		{
		}

		// Token: 0x04002DAB RID: 11691
		[Token(Token = "0x4002DAB")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _servicesService;

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[FieldOffset(Offset = "0x1C")]
		private List<long> _cacheOperationIndexes;
	}
}
