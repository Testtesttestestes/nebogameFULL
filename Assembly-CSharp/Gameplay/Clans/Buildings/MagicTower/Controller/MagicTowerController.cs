using System;
using Gameplay.Clans.Buildings.MagicTower.Events;
using Gameplay.Clans.Buildings.MagicTower.Model;
using Gameplay.School.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.MagicTower;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Buildings.MagicTower.Controller
{
	// Token: 0x02000AB9 RID: 2745
	[Token(Token = "0x2000AB9")]
	public class MagicTowerController : AbstractController<MagicTowerModel, Gameplay.Clans.Buildings.MagicTower.Events.MagicTowerEvents>
	{
		// Token: 0x06004237 RID: 16951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004237")]
		[Address(RVA = "0x90EB", Offset = "0x90EB", VA = "0x90EB")]
		public MagicTowerController(MagicTowerModel model, Gameplay.Clans.Buildings.MagicTower.Events.MagicTowerEvents events)
		{
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004238")]
		[Address(RVA = "0x90EC", Offset = "0x90EC", VA = "0x90EC")]
		public void GetMagicTowerInfo()
		{
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004239")]
		[Address(RVA = "0x90ED", Offset = "0x90ED", VA = "0x90ED")]
		private void GetMagicTowerInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423A")]
		[Address(RVA = "0x90EE", Offset = "0x90EE", VA = "0x90EE")]
		public void StartLearnSpell(SchoolSpellData spell)
		{
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423B")]
		[Address(RVA = "0x90EF", Offset = "0x90EF", VA = "0x90EF")]
		private void StartLearnSpellResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423C")]
		[Address(RVA = "0x90F0", Offset = "0x90F0", VA = "0x90F0")]
		public void CancelLearnSpell(uint spellId)
		{
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423D")]
		[Address(RVA = "0x90F1", Offset = "0x90F1", VA = "0x90F1")]
		private void CancelLearnSpellResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423E")]
		[Address(RVA = "0x90F2", Offset = "0x90F2", VA = "0x90F2")]
		public void AccelerateLearnSpell(SchoolSpellData spell)
		{
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423F")]
		[Address(RVA = "0x90F3", Offset = "0x90F3", VA = "0x90F3")]
		private void AccelerateLearnSpellResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004240")]
		[Address(RVA = "0x90F4", Offset = "0x90F4", VA = "0x90F4")]
		public void UseSpell(SchoolSpellData spell)
		{
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004241")]
		[Address(RVA = "0x90F5", Offset = "0x90F5", VA = "0x90F5")]
		private void UseSpellResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004242")]
		[Address(RVA = "0x90F6", Offset = "0x90F6", VA = "0x90F6")]
		private void SpellActionExpiredEventHandler(ProtoSpellActionExpiredEvt evt)
		{
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004243")]
		[Address(RVA = "0x90F7", Offset = "0x90F7", VA = "0x90F7")]
		private void SpellUsedEventHandler(ProtoSpellUsedEvt evt)
		{
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x90F8", Offset = "0x90F8", VA = "0x90F8")]
		private void LearnSpellStartedEventHandler(ProtoLearnSpellStartedEvt evt)
		{
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x90F9", Offset = "0x90F9", VA = "0x90F9")]
		private void LearnSpellCanceledEventHandler(ProtoLearnSpellCanceledEvt evt)
		{
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x90FA", Offset = "0x90FA", VA = "0x90FA")]
		private void LearnSpellFinishedEventHandler(ProtoLearnSpellFinishedEvt evt)
		{
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004247")]
		[Address(RVA = "0x90FB", Offset = "0x90FB", VA = "0x90FB")]
		private void LearnSpellAcceleratedEventHandler(ProtoLearnSpellAcceleratedEvt evt)
		{
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004248")]
		[Address(RVA = "0x90FC", Offset = "0x90FC", VA = "0x90FC", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x90FD", Offset = "0x90FD", VA = "0x90FD", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424A")]
		[Address(RVA = "0x90FE", Offset = "0x90FE", VA = "0x90FE", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04002490 RID: 9360
		[Token(Token = "0x4002490")]
		[FieldOffset(Offset = "0x18")]
		private MagicTowerService _service;
	}
}
