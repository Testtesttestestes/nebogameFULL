using System;
using Core.Data.Skills;
using Gameplay.Duel.Events;
using Gameplay.Duel.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Duel;
using ServicesNamespace;
using Utils;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	public class DuelController : AbstractController<DuelModel, Gameplay.Duel.Events.DuelEvents>
	{
		// Token: 0x06003274 RID: 12916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003274")]
		[Address(RVA = "0x82C9", Offset = "0x82C9", VA = "0x82C9")]
		public DuelController(DuelModel model, Gameplay.Duel.Events.DuelEvents events)
		{
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003275")]
		[Address(RVA = "0x82CA", Offset = "0x82CA", VA = "0x82CA")]
		public void StartCombatImmediately()
		{
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003276")]
		[Address(RVA = "0x82CB", Offset = "0x82CB", VA = "0x82CB")]
		private void StartListeningForCombatStart(DuelStateInfo state)
		{
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003277")]
		[Address(RVA = "0x82CC", Offset = "0x82CC", VA = "0x82CC")]
		public void GetDuelsInfo(ulong opponentId)
		{
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003278")]
		[Address(RVA = "0x82CD", Offset = "0x82CD", VA = "0x82CD")]
		private void GetDuelInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003279")]
		[Address(RVA = "0x82CE", Offset = "0x82CE", VA = "0x82CE")]
		public void GetUserInfo(params ulong[] userIds)
		{
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327A")]
		[Address(RVA = "0x82CF", Offset = "0x82CF", VA = "0x82CF")]
		private void GetUserInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327B")]
		[Address(RVA = "0x82D0", Offset = "0x82D0", VA = "0x82D0")]
		public void AttackUser(ulong opponentId, uint attackType)
		{
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327C")]
		[Address(RVA = "0x82D1", Offset = "0x82D1", VA = "0x82D1")]
		private void AttackUserResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327D")]
		[Address(RVA = "0x82D2", Offset = "0x82D2", VA = "0x82D2")]
		public void PayOff(ulong opponentId)
		{
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x82D3", Offset = "0x82D3", VA = "0x82D3")]
		private void PayOffResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327F")]
		[Address(RVA = "0x82D4", Offset = "0x82D4", VA = "0x82D4")]
		public void GetDuelStateInfo()
		{
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003280")]
		[Address(RVA = "0x82D5", Offset = "0x82D5", VA = "0x82D5")]
		private void GetDuelStateInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003281")]
		[Address(RVA = "0x82D6", Offset = "0x82D6", VA = "0x82D6")]
		public void PerformIntelligence(ulong opponentId, uint intelligenceType)
		{
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003282")]
		[Address(RVA = "0x82D7", Offset = "0x82D7", VA = "0x82D7")]
		private void PerformIntelligenceResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003283")]
		[Address(RVA = "0x82D8", Offset = "0x82D8", VA = "0x82D8")]
		public void UnsubscribeOpponent(ulong opponentId)
		{
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003284")]
		[Address(RVA = "0x82D9", Offset = "0x82D9", VA = "0x82D9")]
		private void UnsubscribeOpponentResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003285")]
		[Address(RVA = "0x82DA", Offset = "0x82DA", VA = "0x82DA")]
		public void GetUserSkills(ulong playerId, ulong opponentId)
		{
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003286")]
		[Address(RVA = "0x82DB", Offset = "0x82DB", VA = "0x82DB")]
		private void GetPlayerSkillsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x82DC", Offset = "0x82DC", VA = "0x82DC")]
		private void GetOpponentSkillsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x82DD", Offset = "0x82DD", VA = "0x82DD")]
		private SkillCollection ConstructSkills(OpToken<IMessage, object> op)
		{
			return null;
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x82DE", Offset = "0x82DE", VA = "0x82DE")]
		private void HandleChecklist(bool[] checkList)
		{
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328A")]
		[Address(RVA = "0x82DF", Offset = "0x82DF", VA = "0x82DF")]
		private void NewDuelEventHandler(DuelStateInfo state)
		{
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328B")]
		[Address(RVA = "0x82E0", Offset = "0x82E0", VA = "0x82E0")]
		private void PaidOffEventHandler(ProtoDuelPaidOffEvt evt)
		{
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328C")]
		[Address(RVA = "0x82E1", Offset = "0x82E1", VA = "0x82E1")]
		private void UserStateFlagsChangedEventHandler(ProtoDuelUserStateChangedEvt evt)
		{
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328D")]
		[Address(RVA = "0x82E2", Offset = "0x82E2", VA = "0x82E2")]
		private void HandleDuelState(DuelStateInfo state)
		{
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328E")]
		[Address(RVA = "0x82E3", Offset = "0x82E3", VA = "0x82E3")]
		public void RequestNecessaryUserInfos(ulong playerId, ulong opponentId)
		{
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600328F")]
		[Address(RVA = "0x82E4", Offset = "0x82E4", VA = "0x82E4")]
		private void SubscribeToEvents()
		{
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003290")]
		[Address(RVA = "0x82E5", Offset = "0x82E5", VA = "0x82E5")]
		private void UnsubscribeFromEvents()
		{
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003291")]
		[Address(RVA = "0x82E6", Offset = "0x82E6", VA = "0x82E6", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003292")]
		[Address(RVA = "0x82E7", Offset = "0x82E7", VA = "0x82E7", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x82E8", Offset = "0x82E8", VA = "0x82E8", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04001BAB RID: 7083
		[Token(Token = "0x4001BAB")]
		[FieldOffset(Offset = "0x18")]
		private DuelService _duelService;

		// Token: 0x04001BAC RID: 7084
		[Token(Token = "0x4001BAC")]
		[FieldOffset(Offset = "0x1C")]
		private MainService _mainService;
	}
}
