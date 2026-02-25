using System;
using System.Collections;
using System.Collections.Generic;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.GameEvents.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Events;
using Protocol.Main;
using ServicesNamespace;
using Utils;
using Utils.Timers;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007E0 RID: 2016
	[Token(Token = "0x20007E0")]
	public class GameEventsController : AbstractController<GameEventsModel, GameEventsEvents>
	{
		// Token: 0x06002F2A RID: 12074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x7F97", Offset = "0x7F97", VA = "0x7F97", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0x7F98", Offset = "0x7F98", VA = "0x7F98")]
		public GameEventsController(GameEventsModel model, GameEventsEvents events)
		{
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0x7F99", Offset = "0x7F99", VA = "0x7F99", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x7F9A", Offset = "0x7F9A", VA = "0x7F9A", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x7F9B", Offset = "0x7F9B", VA = "0x7F9B")]
		private void ExpirationSchedulerCallback()
		{
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x7F9C", Offset = "0x7F9C", VA = "0x7F9C")]
		private void ValidateInit()
		{
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x7F9D", Offset = "0x7F9D", VA = "0x7F9D")]
		private void SetEvents(ProtoGetEventsListAns msg)
		{
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x1AC8", Offset = "0x1AC8", VA = "0x1AC8")]
		private void SetNotViewedEventCount(EventCategoriesDic.Types.Category category, int value)
		{
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F32")]
		[Address(RVA = "0x7F9E", Offset = "0x7F9E", VA = "0x7F9E")]
		private void RemoveEvent(GameEventData evt)
		{
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F33")]
		[Address(RVA = "0x7F9F", Offset = "0x7F9F", VA = "0x7F9F")]
		private IEnumerator EventProcessCompleteCoroutine(GameEventData evt)
		{
			return null;
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F34")]
		[Address(RVA = "0x7FA0", Offset = "0x7FA0", VA = "0x7FA0")]
		private EventCategoriesDic GetArchiveCategory()
		{
			return null;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F35")]
		[Address(RVA = "0x7FA1", Offset = "0x7FA1", VA = "0x7FA1")]
		private void MoveToArchive(GameEventData evt)
		{
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F36")]
		[Address(RVA = "0x7FA2", Offset = "0x7FA2", VA = "0x7FA2")]
		private void IncreaseNotViewedEventsCount(GameEventData evt)
		{
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F37")]
		[Address(RVA = "0x7FA3", Offset = "0x7FA3", VA = "0x7FA3")]
		private void DecreaseNotViewedEventsCount(GameEventData evt)
		{
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x6002F38")]
		[Address(RVA = "0x1ACA", Offset = "0x1ACA", VA = "0x1ACA")]
		private bool TryScheduleByExpirations(DelayedCall scheduler, float? scheduleThreshold)
		{
			return default(bool);
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x6002F39")]
		[Address(RVA = "0x1AC9", Offset = "0x1AC9", VA = "0x1AC9")]
		private bool TryDeleteExpired(out IList<GameEventData> deleted)
		{
			return default(bool);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x6002F3A")]
		[Address(RVA = "0x1AC2", Offset = "0x1AC2", VA = "0x1AC2")]
		private UniTask<UniTask> WarmSourceInfo(IEnumerable<ProtoGetEventsListAns.Types.EventInfo> eventsInfos)
		{
			return default(UniTask<UniTask>);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x6002F3B")]
		[Address(RVA = "0x1AC0", Offset = "0x1AC0", VA = "0x1AC0")]
		private UniTask<UniTask> WarmSourceInfo(IEnumerable<GameEventData> events)
		{
			return default(UniTask<UniTask>);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000099D8 File Offset: 0x00007BD8
		[Token(Token = "0x6002F3C")]
		[Address(RVA = "0x7FA4", Offset = "0x7FA4", VA = "0x7FA4")]
		private UniTask<UniTask> WarmSourceInfo(List<ulong> userIds, List<ulong> clanIds)
		{
			return default(UniTask<UniTask>);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x7FA5", Offset = "0x7FA5", VA = "0x7FA5")]
		private void ValidateExpired()
		{
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x7FA6", Offset = "0x7FA6", VA = "0x7FA6")]
		private void HandleThereIsNewEvent(ProtoGetEventsListAns msg)
		{
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x7FA7", Offset = "0x7FA7", VA = "0x7FA7")]
		private void HandleArtifactDropRemoveEvent(DropTypes dropType, ArtifactData artifactData)
		{
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x7FA8", Offset = "0x7FA8", VA = "0x7FA8")]
		private void HandleDropRemoveEvent(DropTypes dropType)
		{
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x7FA9", Offset = "0x7FA9", VA = "0x7FA9")]
		private void RequestProcessEvent(GameEventData evt)
		{
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x7FAA", Offset = "0x7FAA", VA = "0x7FAA")]
		private void HandleProcessEventService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F43")]
		[Address(RVA = "0x7FAB", Offset = "0x7FAB", VA = "0x7FAB")]
		private void RequestGetEventReward(GameEventData evt)
		{
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F44")]
		[Address(RVA = "0x7FAC", Offset = "0x7FAC", VA = "0x7FAC")]
		private void HandleGetEventRewardService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F45")]
		[Address(RVA = "0x7FAD", Offset = "0x7FAD", VA = "0x7FAD")]
		private void RequestDelete(ulong[] ids)
		{
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F46")]
		[Address(RVA = "0x7FAE", Offset = "0x7FAE", VA = "0x7FAE")]
		private void HandleDeleteEventsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F47")]
		[Address(RVA = "0x7FAF", Offset = "0x7FAF", VA = "0x7FAF")]
		private void RequestEventsList()
		{
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F48")]
		[Address(RVA = "0x7FB0", Offset = "0x7FB0", VA = "0x7FB0")]
		private void HandleGetEventsList(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F49")]
		[Address(RVA = "0x7FB1", Offset = "0x7FB1", VA = "0x7FB1")]
		public void NotifyEventHasBeenViewed(GameEventData evt)
		{
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x7FB2", Offset = "0x7FB2", VA = "0x7FB2")]
		public void SetCurrentReadEvent(GameEventData evt)
		{
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4B")]
		[Address(RVA = "0x7FB3", Offset = "0x7FB3", VA = "0x7FB3")]
		public void Delete(List<GameEventData> events)
		{
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x7FB4", Offset = "0x7FB4", VA = "0x7FB4")]
		public void GetReward(GameEventData evt)
		{
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4D")]
		[Address(RVA = "0x7FB5", Offset = "0x7FB5", VA = "0x7FB5")]
		public void HandleEventActions(GameEventData evt)
		{
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x7FB6", Offset = "0x7FB6", VA = "0x7FB6")]
		public void Read(GameEventData evt)
		{
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x7FB7", Offset = "0x7FB7", VA = "0x7FB7")]
		public void RequestOpenListView(EventCategoriesDic category)
		{
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x7FB8", Offset = "0x7FB8", VA = "0x7FB8")]
		public static void FillGameEventBackground(GameEventData evt)
		{
		}

		// Token: 0x040019BD RID: 6589
		[Token(Token = "0x40019BD")]
		[FieldOffset(Offset = "0x18")]
		private EventsService _service;

		// Token: 0x040019BE RID: 6590
		[Token(Token = "0x40019BE")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _expirationScheduler;
	}
}
