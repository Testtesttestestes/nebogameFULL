using System;
using Core.Data;
using Gameplay.Isles.Axis;
using Gameplay.Isles.Clan;
using Gameplay.Isles.User;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Clans;
using Protocol.World;
using ServicesNamespace;
using Utils;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public class WorldController : AbstractController<WorldModel, WorldControllerEvents>, IUserIslesWorldMovement, IClanIslesWorldMovement
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x6672", Offset = "0x6672", VA = "0x6672", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x6673", Offset = "0x6673", VA = "0x6673")]
		public WorldController(WorldModel model, WorldControllerEvents controllerEvents)
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x6674", Offset = "0x6674", VA = "0x6674", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x6675", Offset = "0x6675", VA = "0x6675", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x6676", Offset = "0x6676", VA = "0x6676")]
		private void HandleDictProviderOnChangedEvent()
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x6677", Offset = "0x6677", VA = "0x6677")]
		private void ClansServiceOnTreasuryChangedEvent(ProtoTreasuryChangedEvt msg)
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x6678", Offset = "0x6678", VA = "0x6678")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x6679", Offset = "0x6679", VA = "0x6679")]
		private void ClansServiceOnClanUnregisteredEvent(ProtoUnregisterClanAns ans)
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x667A", Offset = "0x667A", VA = "0x667A")]
		private void AnimationTimerExpiredEventHandler()
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x667B", Offset = "0x667B", VA = "0x667B")]
		private void WorldServiceOnIsleMonsterInfoChangedEvent(ProtoIsleMonsterInfoChangedEvt msg)
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x667C", Offset = "0x667C", VA = "0x667C")]
		private void WorldServiceOnIsleMonsterFlewAwayEvent(ProtoIsleMonsterFlewAwayEvt evt)
		{
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x667D", Offset = "0x667D", VA = "0x667D")]
		private void WorldServiceGoHomeEventHandler(ProtoGoHomeEvt evt)
		{
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x667E", Offset = "0x667E", VA = "0x667E")]
		public bool TryAttackMonsterFromCurrentIsle([NotNull] MonsterData monster)
		{
			return default(bool);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x667F", Offset = "0x667F", VA = "0x667F")]
		public void KickMonsterFromCurrentIsle()
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x6680", Offset = "0x6680", VA = "0x6680")]
		public bool TryRequestMonsterForCurrentUserIsle()
		{
			return default(bool);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x6681", Offset = "0x6681", VA = "0x6681")]
		private void MonsterKickedServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x6682", Offset = "0x6682", VA = "0x6682")]
		private void GetMonsterInfoServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x6683", Offset = "0x6683", VA = "0x6683", Slot = "14")]
		public void GoToClanIsle(ulong clanId)
		{
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x6684", Offset = "0x6684", VA = "0x6684")]
		private void GetClanIsleInfoServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x6685", Offset = "0x6685", VA = "0x6685", Slot = "13")]
		public void GoToUserIsle(ulong userId, bool force = false)
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x6686", Offset = "0x6686", VA = "0x6686")]
		private void GetUserIsleInfoServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x6687", Offset = "0x6687", VA = "0x6687")]
		private void ValidateInit()
		{
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x6688", Offset = "0x6688", VA = "0x6688")]
		public void GoToAxisIsle()
		{
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x6689", Offset = "0x6689", VA = "0x6689")]
		private void GetColossusInfoServiceResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x668A", Offset = "0x668A", VA = "0x668A")]
		private void SetCurrentUserIsleData(UserIsle userIsleData)
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x668B", Offset = "0x668B", VA = "0x668B")]
		private void SetCurrentClanIsleData(ClanIsle clanIsleData)
		{
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x668C", Offset = "0x668C", VA = "0x668C")]
		private void SetCurrentAxisIsleData(AxisIsle axisIsleData)
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x668D", Offset = "0x668D", VA = "0x668D", Slot = "12")]
		public void GoHome()
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x668E", Offset = "0x668E", VA = "0x668E")]
		private void ClearUserIsleHeap()
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x668F", Offset = "0x668F", VA = "0x668F")]
		private void ClearClanIsleHeap()
		{
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x6690", Offset = "0x6690", VA = "0x6690")]
		private void DisposeIsle(UserIsle isle)
		{
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x6691", Offset = "0x6691", VA = "0x6691")]
		private void DisposeIsle(ClanIsle isle)
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x6692", Offset = "0x6692", VA = "0x6692")]
		public void GetIsleAnimationsInfo()
		{
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x6693", Offset = "0x6693", VA = "0x6693")]
		private void HandleServiceGetAnimationsInfo(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x6694", Offset = "0x6694", VA = "0x6694")]
		public void StartAnimation(IsleAnimationRequestVo data)
		{
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x6695", Offset = "0x6695", VA = "0x6695")]
		private void HandleServiceStartAnimation(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x6696", Offset = "0x6696", VA = "0x6696")]
		public void KickFromIsle(ulong userId)
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x6697", Offset = "0x6697", VA = "0x6697")]
		private void HandleServiceKickFromIsle(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x18")]
		private bool _userHasClan;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x1C")]
		private WorldService _worldService;

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x20")]
		private ClanIsleService _clanIsleService;

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0x24")]
		private ColossusService _colossusService;

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x28")]
		private readonly CommandsRepository _commandsRepository;

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x2C")]
		private ClansService _clansService;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x30")]
		private OpToken<IMessage, object> _tokenOfGetUserIsleInfoRequest;
	}
}
