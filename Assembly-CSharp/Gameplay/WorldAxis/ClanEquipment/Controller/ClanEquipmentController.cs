using System;
using Core.Data;
using Gameplay.WorldAxis.ClanEquipment.Events;
using Gameplay.WorldAxis.ClanEquipment.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.ClanEquipment.Controller
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public class ClanEquipmentController : AbstractController<ClanEquipmentModel, ClanEquipmentEvents>
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x654F", Offset = "0x654F", VA = "0x654F")]
		public ClanEquipmentController(ClanEquipmentModel model, ClanEquipmentEvents events)
		{
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x6550", Offset = "0x6550", VA = "0x6550", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x6551", Offset = "0x6551", VA = "0x6551")]
		public void GetDollArtifacts()
		{
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x6552", Offset = "0x6552", VA = "0x6552")]
		private void GetDollArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x6553", Offset = "0x6553", VA = "0x6553")]
		private void UsersRequestedEventHandler(long operationIndex, UserData[] data, ProtoGetDollArtsAns msg)
		{
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x6554", Offset = "0x6554", VA = "0x6554")]
		public void TakeOffArtifacts(ulong userId, params ulong[] dollIds)
		{
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x6555", Offset = "0x6555", VA = "0x6555")]
		private void TakeOffArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
