using System;
using DG.Tweening;
using Gameplay.Clans.Events;
using Gameplay.WorldAxis.Events;
using Gameplay.WorldAxis.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Controller
{
	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	public class WorldAxisController : AbstractController<WorldAxisModel, WorldAxisEvents>
	{
		// Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x62CC", Offset = "0x62CC", VA = "0x62CC")]
		public WorldAxisController(WorldAxisModel model, WorldAxisEvents events, ClansEvents clansEvents)
		{
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x62CD", Offset = "0x62CD", VA = "0x62CD", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x62CE", Offset = "0x62CE", VA = "0x62CE", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x62CF", Offset = "0x62CF", VA = "0x62CF")]
		private void InventoryChangedEventHandler(ProtoInventoryChangedEvt evt)
		{
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x62D0", Offset = "0x62D0", VA = "0x62D0")]
		public void GetSchedule()
		{
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x62D1", Offset = "0x62D1", VA = "0x62D1")]
		private void GetSchedultResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x62D2", Offset = "0x62D2", VA = "0x62D2")]
		public void GetAvailableDolls()
		{
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x62D3", Offset = "0x62D3", VA = "0x62D3")]
		private void GetAvailableDollsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x62D4", Offset = "0x62D4", VA = "0x62D4")]
		public void GetPartyInfo()
		{
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x62D5", Offset = "0x62D5", VA = "0x62D5")]
		private void GetPartyInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x62D6", Offset = "0x62D6", VA = "0x62D6")]
		public void FromGolemToDoll(ulong artifactId, ulong dollId, uint slotId)
		{
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x62D7", Offset = "0x62D7", VA = "0x62D7")]
		private void FromGolemToDollResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x62D8", Offset = "0x62D8", VA = "0x62D8")]
		public void FromDollToGolem(ulong artifactId, uint fromSlotId)
		{
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x62D9", Offset = "0x62D9", VA = "0x62D9")]
		private void FromDollToGolemResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x62DA", Offset = "0x62DA", VA = "0x62DA")]
		public void SelectDoll(DollsInfoDic doll)
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x62DB", Offset = "0x62DB", VA = "0x62DB")]
		private void SelectDollResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x62DC", Offset = "0x62DC", VA = "0x62DC")]
		public void GetColossusInfo()
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x62DD", Offset = "0x62DD", VA = "0x62DD")]
		private void GetColossusInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0x62DE", Offset = "0x62DE", VA = "0x62DE")]
		private void ScheduleChangedEventHandler(ProtoGetScheduleAns msg)
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x62DF", Offset = "0x62DF", VA = "0x62DF")]
		private void ColossusChangedEventHandler(ProtoGetColossusInfoAns msg)
		{
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x62E0", Offset = "0x62E0", VA = "0x62E0")]
		private void ClanStatusChangedEventHandler()
		{
		}

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x1C")]
		private ClansEvents _clansEvents;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x20")]
		private Tween _timer;
	}
}
