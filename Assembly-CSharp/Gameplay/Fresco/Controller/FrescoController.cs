using System;
using System.Collections.Generic;
using Core.Data.Balance;
using Gameplay.Bank.Model;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View.Groups;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Fresco;
using ServicesNamespace;
using Utils;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x0200080B RID: 2059
	[Token(Token = "0x200080B")]
	public class FrescoController : AbstractController<FrescoModel, Gameplay.Fresco.Events.FrescoEvents>
	{
		// Token: 0x0600305F RID: 12383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x80C4", Offset = "0x80C4", VA = "0x80C4")]
		public FrescoController(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoService frescoService, IBalanceSource balanceSource)
		{
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x80C5", Offset = "0x80C5", VA = "0x80C5", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x80C6", Offset = "0x80C6", VA = "0x80C6", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x80C7", Offset = "0x80C7", VA = "0x80C7")]
		private void StartListen()
		{
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x80C8", Offset = "0x80C8", VA = "0x80C8")]
		private void StopListen()
		{
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003064")]
		[Address(RVA = "0x80C9", Offset = "0x80C9", VA = "0x80C9")]
		private void FrescoUpdatedHandler(ProtoFrescoUpdatedEvt msg)
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003065")]
		[Address(RVA = "0x80CA", Offset = "0x80CA", VA = "0x80CA")]
		private void HandleBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x80CB", Offset = "0x80CB", VA = "0x80CB")]
		private void FrescoUniversalFragmentsChangedHandler(ProtoFrescoUniversalFragmentsChangedEvt msg)
		{
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x80CC", Offset = "0x80CC", VA = "0x80CC")]
		private void GetBankOptions()
		{
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x80CD", Offset = "0x80CD", VA = "0x80CD")]
		public void GetUserFrescoes()
		{
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003069")]
		[Address(RVA = "0x80CE", Offset = "0x80CE", VA = "0x80CE")]
		public void GetOtherUserFrescoes(ulong userId)
		{
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306A")]
		[Address(RVA = "0x80CF", Offset = "0x80CF", VA = "0x80CF")]
		public void FillFrescoSlots(ulong frescoId, uint[] index)
		{
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306B")]
		[Address(RVA = "0x80D0", Offset = "0x80D0", VA = "0x80D0")]
		public void CompleteFresco(ulong frescoId)
		{
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x80D1", Offset = "0x80D1", VA = "0x80D1")]
		public void CollectFrescoReward(ulong frescoId)
		{
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x80D2", Offset = "0x80D2", VA = "0x80D2")]
		public void InstallUniversalFragments(ulong frescoId, uint[] index)
		{
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x80D3", Offset = "0x80D3", VA = "0x80D3")]
		public void GetUniversalFragments()
		{
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306F")]
		[Address(RVA = "0x80D4", Offset = "0x80D4", VA = "0x80D4")]
		private void GetUserFrescoesHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003070")]
		[Address(RVA = "0x80D5", Offset = "0x80D5", VA = "0x80D5")]
		private void GetOtherUserFrescoesHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003071")]
		[Address(RVA = "0x80D6", Offset = "0x80D6", VA = "0x80D6")]
		private void ValidateData()
		{
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003072")]
		[Address(RVA = "0x80D7", Offset = "0x80D7", VA = "0x80D7")]
		private List<FrescoGroupListElementArgs> GetData(RepeatedField<Fresco> frescoes)
		{
			return null;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x80D8", Offset = "0x80D8", VA = "0x80D8")]
		private void FillFrescoSlotsHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x80D9", Offset = "0x80D9", VA = "0x80D9")]
		private void CompleteFrescoHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003075")]
		[Address(RVA = "0x80DA", Offset = "0x80DA", VA = "0x80DA")]
		private void CollectFrescoRewardHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x80DB", Offset = "0x80DB", VA = "0x80DB")]
		private void InstallUniversalFragmentsHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x80DC", Offset = "0x80DC", VA = "0x80DC")]
		private void GetUniversalFragmentsCountHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003078")]
		[Address(RVA = "0x80DD", Offset = "0x80DD", VA = "0x80DD")]
		private void UpdateFresco(Fresco fresco)
		{
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003079")]
		[Address(RVA = "0x80DE", Offset = "0x80DE", VA = "0x80DE")]
		private void UpdateCurrentGroup()
		{
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x80DF", Offset = "0x80DF", VA = "0x80DF")]
		private void UpdateBalance(uint count)
		{
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x80E0", Offset = "0x80E0", VA = "0x80E0")]
		private void ValidateInit()
		{
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x80E1", Offset = "0x80E1", VA = "0x80E1")]
		public void Buy(BankOptionData option)
		{
		}

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x18")]
		private readonly FrescoService _frescoService;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IBalanceSource _balanceSource;
	}
}
