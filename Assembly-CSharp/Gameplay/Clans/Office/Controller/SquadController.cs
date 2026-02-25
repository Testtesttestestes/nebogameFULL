using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	public class SquadController : AbstractController<SquadModel, SquadEvents>
	{
		// Token: 0x06003FCE RID: 16334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x8E88", Offset = "0x8E88", VA = "0x8E88")]
		public SquadController(SquadModel model, SquadEvents events, ClanInfoController clanInfoController)
		{
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x8E89", Offset = "0x8E89", VA = "0x8E89", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x8E8A", Offset = "0x8E8A", VA = "0x8E8A", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x8E8B", Offset = "0x8E8B", VA = "0x8E8B")]
		public void GetPartyInfo()
		{
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x8E8C", Offset = "0x8E8C", VA = "0x8E8C")]
		private void GetPartyInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x8E8D", Offset = "0x8E8D", VA = "0x8E8D")]
		public void SwapPartySlot(uint partyId, uint slotId)
		{
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0x8E8E", Offset = "0x8E8E", VA = "0x8E8E")]
		private void SwapPartySlotResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD5")]
		[Address(RVA = "0x8E8F", Offset = "0x8E8F", VA = "0x8E8F")]
		public void BuyPartySlot(uint partyId, ResourceSet price)
		{
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD6")]
		[Address(RVA = "0x8E90", Offset = "0x8E90", VA = "0x8E90")]
		private void BuyPartySlotReslutHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD7")]
		[Address(RVA = "0x8E91", Offset = "0x8E91", VA = "0x8E91")]
		public void BuyParty(ResourceSet price)
		{
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD8")]
		[Address(RVA = "0x8E92", Offset = "0x8E92", VA = "0x8E92")]
		private void BuyPartyReslutHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD9")]
		[Address(RVA = "0x8E93", Offset = "0x8E93", VA = "0x8E93")]
		private void SlotsChangedEventHandler(ProtoSlotsChanged msg)
		{
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x8E94", Offset = "0x8E94", VA = "0x8E94")]
		private void ChangeSlotsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[FieldOffset(Offset = "0x1C")]
		public readonly ClanInfoController ClanInfoController;
	}
}
