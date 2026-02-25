using System;
using System.Collections;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.World;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D3B RID: 3387
	[Token(Token = "0x2000D3B")]
	public class UserIsleController : BaseIsleController<UserIsleModel, UserIsleEvents>
	{
		// Token: 0x060052E0 RID: 21216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E0")]
		[Address(RVA = "0xA0B6", Offset = "0xA0B6", VA = "0xA0B6")]
		public UserIsleController(UserIsleModel model, UserIsleEvents events)
		{
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E1")]
		[Address(RVA = "0xA0B7", Offset = "0xA0B7", VA = "0xA0B7")]
		public void CollectAllBonuses(uint[] positionIds)
		{
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E2")]
		[Address(RVA = "0xA0B8", Offset = "0xA0B8", VA = "0xA0B8")]
		private void HandleBonusQueue()
		{
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E3")]
		[Address(RVA = "0xA0B9", Offset = "0xA0B9", VA = "0xA0B9")]
		private void GetBonusServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0xA0BA", Offset = "0xA0BA", VA = "0xA0BA")]
		private void HandleLicenceSpent()
		{
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E5")]
		[Address(RVA = "0xA0BB", Offset = "0xA0BB", VA = "0xA0BB")]
		private void OnDiamondIsleFound()
		{
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E6")]
		[Address(RVA = "0xA0BC", Offset = "0xA0BC", VA = "0xA0BC")]
		public void StartBuild(uint buildingTypeId)
		{
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E7")]
		[Address(RVA = "0xA0BD", Offset = "0xA0BD", VA = "0xA0BD")]
		private void StartBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0000F018 File Offset: 0x0000D218
		[Token(Token = "0x60052E8")]
		[Address(RVA = "0xA0BE", Offset = "0xA0BE", VA = "0xA0BE")]
		public bool TryAccelerateBuild(uint buildingTypeId)
		{
			return default(bool);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052E9")]
		[Address(RVA = "0xA0BF", Offset = "0xA0BF", VA = "0xA0BF")]
		private void AccelerateBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EA")]
		[Address(RVA = "0xA0C0", Offset = "0xA0C0", VA = "0xA0C0")]
		public void CancelBuild(uint buildingTypeId)
		{
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052EB")]
		[Address(RVA = "0xA0C1", Offset = "0xA0C1", VA = "0xA0C1")]
		public ResourceSet GetCancelImproveMoneyBack(uint buildingType)
		{
			return null;
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EC")]
		[Address(RVA = "0xA0C2", Offset = "0xA0C2", VA = "0xA0C2")]
		private void CancelBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052ED")]
		[Address(RVA = "0xA0C3", Offset = "0xA0C3", VA = "0xA0C3", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EE")]
		[Address(RVA = "0xA0C4", Offset = "0xA0C4", VA = "0xA0C4", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052EF")]
		[Address(RVA = "0xA0C5", Offset = "0xA0C5", VA = "0xA0C5")]
		private void HandleAccountChangedEvent(AccountInfo account)
		{
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F0")]
		[Address(RVA = "0xA0C6", Offset = "0xA0C6", VA = "0xA0C6")]
		private void WorldServiceOnAnimationStartedEvent(ProtoAnimationStartedEvt evt)
		{
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F1")]
		[Address(RVA = "0xA0C7", Offset = "0xA0C7", VA = "0xA0C7")]
		private void WorldServiceOnBuildingFinishedEvent(ProtoBuildingFinishedEvt evt)
		{
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F2")]
		[Address(RVA = "0xA0C8", Offset = "0xA0C8", VA = "0xA0C8")]
		private void WorldServiceOnBuildingCanceledEvent(ProtoBuildingCanceledEvt evt)
		{
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F3")]
		[Address(RVA = "0xA0C9", Offset = "0xA0C9", VA = "0xA0C9")]
		private void WorldServiceOnBuildingAcceleratedEvent(ProtoBuildingAcceleratedEvt evt)
		{
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F4")]
		[Address(RVA = "0xA0CA", Offset = "0xA0CA", VA = "0xA0CA")]
		private void WorldServiceOnBuildingStartedEvent(ProtoBuildingStartedEvt evt)
		{
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F5")]
		[Address(RVA = "0xA0CB", Offset = "0xA0CB", VA = "0xA0CB")]
		private void WorldServiceUserIsleBuildingViewChangedEvent(ProtoUserIsleBuildingViewChangedEvt evt)
		{
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F6")]
		[Address(RVA = "0xA0CC", Offset = "0xA0CC", VA = "0xA0CC")]
		private void IsleMonsterFlewAwayEventHandler(ProtoIsleMonsterFlewAwayEvt evt)
		{
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F7")]
		[Address(RVA = "0xA0CD", Offset = "0xA0CD", VA = "0xA0CD")]
		private void ShowCompleteBuildToast(BaseBuildingData buildingData)
		{
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F8")]
		[Address(RVA = "0xA0CE", Offset = "0xA0CE", VA = "0xA0CE")]
		private void RequestMonster()
		{
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052F9")]
		[Address(RVA = "0xA0CF", Offset = "0xA0CF", VA = "0xA0CF")]
		private void OnMonsterChangedEvent(ulong ownerId, WorldControllerEvents.MonsterChangeReason reason)
		{
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FA")]
		[Address(RVA = "0xA0D0", Offset = "0xA0D0", VA = "0xA0D0")]
		private void ValidateMonsterTimer()
		{
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FB")]
		[Address(RVA = "0xA0D1", Offset = "0xA0D1", VA = "0xA0D1")]
		private void StartMonsterTimer(MonsterData monster)
		{
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x60052FC")]
		[Address(RVA = "0xA0D2", Offset = "0xA0D2", VA = "0xA0D2")]
		private bool TryStopMonsterTimer()
		{
			return default(bool);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052FD")]
		[Address(RVA = "0xA0D3", Offset = "0xA0D3", VA = "0xA0D3")]
		private IEnumerator SetupMonsterTimerRoutine(BackTime backTime)
		{
			return null;
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FE")]
		[Address(RVA = "0xA0D4", Offset = "0xA0D4", VA = "0xA0D4")]
		private void OnTimerExpired()
		{
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052FF")]
		[Address(RVA = "0xA0D5", Offset = "0xA0D5", VA = "0xA0D5", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005300")]
		[Address(RVA = "0x1C9F", Offset = "0x1C9F", VA = "0x1C9F")]
		public void SetIsleInformation(ProtoGetUserIsleInfoAns.Types.IsleInformation isleInformation)
		{
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005301")]
		[Address(RVA = "0xA0D6", Offset = "0xA0D6", VA = "0xA0D6")]
		private void WorldServiceOnUserIsleDecorationRemovedEvent(ProtoUserIsleDecorationRemovedEvt evt)
		{
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005302")]
		[Address(RVA = "0xA0D7", Offset = "0xA0D7", VA = "0xA0D7")]
		private void WorldServiceOnUserIsleDecorationAddedEvent(ProtoUserIsleDecorationAddedEvt evt)
		{
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005303")]
		[Address(RVA = "0xA0D8", Offset = "0xA0D8", VA = "0xA0D8")]
		private void ValidateAccountMarkers()
		{
		}

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		[FieldOffset(Offset = "0x18")]
		private WorldService _worldService;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0x1C")]
		private TreeService _treeService;

		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		[FieldOffset(Offset = "0x20")]
		private ServicesService _servicesService;

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _monsterTimerCoroutine;

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0x28")]
		private Queue<uint> _isleBonusesToCollect;

		// Token: 0x02000D3C RID: 3388
		[Token(Token = "0x2000D3C")]
		public enum RequestFlag
		{
			// Token: 0x04002D01 RID: 11521
			[Token(Token = "0x4002D01")]
			UNKNOWN,
			// Token: 0x04002D02 RID: 11522
			[Token(Token = "0x4002D02")]
			START_BUILD
		}
	}
}
