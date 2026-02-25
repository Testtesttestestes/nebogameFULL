using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.DailyQuests;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;
using Utils.Timers;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x02000888 RID: 2184
	[Token(Token = "0x2000888")]
	public class DailyQuestsController : AbstractController<DailyQuestsModel, DailyQuestEvents>, IDailyQuestProvider
	{
		// Token: 0x06003369 RID: 13161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003369")]
		[Address(RVA = "0x83A4", Offset = "0x83A4", VA = "0x83A4", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336A")]
		[Address(RVA = "0x83A5", Offset = "0x83A5", VA = "0x83A5")]
		public DailyQuestsController(QuestsTriggerObserver questsTriggerQuestsTriggerObserver, DailyQuestsService service, DailyQuestsModel model, DailyQuestEvents events)
		{
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336B")]
		[Address(RVA = "0x83A6", Offset = "0x83A6", VA = "0x83A6", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336C")]
		[Address(RVA = "0x83A7", Offset = "0x83A7", VA = "0x83A7", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336D")]
		[Address(RVA = "0x83A8", Offset = "0x83A8", VA = "0x83A8")]
		private void StopListen()
		{
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336E")]
		[Address(RVA = "0x83A9", Offset = "0x83A9", VA = "0x83A9")]
		private void ValidateInit()
		{
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336F")]
		[Address(RVA = "0x83AA", Offset = "0x83AA", VA = "0x83AA")]
		private void StartListen()
		{
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003370")]
		[Address(RVA = "0x83AB", Offset = "0x83AB", VA = "0x83AB")]
		private void DailyQuestsChangedEventHandler(ProtoDailyQuestsChangedEvt _)
		{
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003371")]
		[Address(RVA = "0x83AC", Offset = "0x83AC", VA = "0x83AC")]
		private void HandleDictionariesChangedEvent()
		{
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003372")]
		[Address(RVA = "0x83AD", Offset = "0x83AD", VA = "0x83AD")]
		private void TriggerChangedEventHandler(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003373")]
		[Address(RVA = "0x83AE", Offset = "0x83AE", VA = "0x83AE")]
		private void RequestNewDailyQuests()
		{
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x83AF", Offset = "0x83AF", VA = "0x83AF")]
		private void RequestAllDailyQuests()
		{
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x83B0", Offset = "0x83B0", VA = "0x83B0")]
		private void GetAllDailyQuestsServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x83B1", Offset = "0x83B1", VA = "0x83B1")]
		private void RequestAllGoals()
		{
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x83B2", Offset = "0x83B2", VA = "0x83B2")]
		private void GetAllGoalsServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x83B3", Offset = "0x83B3", VA = "0x83B3")]
		public void TakeDailyQuestReward(uint questId)
		{
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x83B4", Offset = "0x83B4", VA = "0x83B4")]
		private void TakeDailyQuestRewardServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x83B5", Offset = "0x83B5", VA = "0x83B5")]
		public void TakeGoalReward(uint goalId)
		{
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x83B6", Offset = "0x83B6", VA = "0x83B6")]
		private void TakeGoalRewardServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x83B7", Offset = "0x83B7", VA = "0x83B7")]
		private void GetGoals(IEnumerable<uint> goalIds)
		{
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337D")]
		[Address(RVA = "0x83B8", Offset = "0x83B8", VA = "0x83B8")]
		private void GetGoalsServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337E")]
		[Address(RVA = "0x83B9", Offset = "0x83B9", VA = "0x83B9")]
		private void GetDailyQuests(IEnumerable<uint> goalIds)
		{
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337F")]
		[Address(RVA = "0x83BA", Offset = "0x83BA", VA = "0x83BA")]
		private void GetDailyQuestsServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x6003380")]
		[Address(RVA = "0x83BB", Offset = "0x83BB", VA = "0x83BB")]
		private float GetApproximateProgress(IQuest dailyQuestData)
		{
			return 0f;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003381")]
		[Address(RVA = "0x83BC", Offset = "0x83BC", VA = "0x83BC")]
		private void SetupBackTimeTimer(BackTime backTime)
		{
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x83BD", Offset = "0x83BD", VA = "0x83BD")]
		private void CheckQuestsForCompletion()
		{
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x83BE", Offset = "0x83BE", VA = "0x83BE")]
		private void CheckQuestsForCompletion(IEnumerable<IQuest> quests, ref bool activeCountChanged)
		{
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x83BF", Offset = "0x83BF", VA = "0x83BF", Slot = "12")]
		public IDailyQuest GetQuest(uint id)
		{
			return null;
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x1BC4", Offset = "0x1BC4", VA = "0x1BC4")]
		[CompilerGenerated]
		private bool <CheckQuestsForCompletion>g__RecalculateProgress|30_0(IQuest quest)
		{
			return default(bool);
		}

		// Token: 0x04001C0C RID: 7180
		[Token(Token = "0x4001C0C")]
		[FieldOffset(Offset = "0x18")]
		private readonly QuestsTriggerObserver _questsTriggerObserver;

		// Token: 0x04001C0D RID: 7181
		[Token(Token = "0x4001C0D")]
		[FieldOffset(Offset = "0x1C")]
		private readonly DailyQuestsService _dailyQuestsService;

		// Token: 0x04001C0E RID: 7182
		[Token(Token = "0x4001C0E")]
		[FieldOffset(Offset = "0x20")]
		private DelayedCall _delayedCall;

		// Token: 0x04001C0F RID: 7183
		[Token(Token = "0x4001C0F")]
		[FieldOffset(Offset = "0x24")]
		private int _initialRequestCount;
	}
}
