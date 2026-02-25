using System;
using System.Collections;
using Gameplay.MageSchool.Events;
using Gameplay.School.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.School;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.School.Controller
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	public class SchoolController : AbstractController<SchoolModel, Gameplay.MageSchool.Events.SchoolEvents>
	{
		// Token: 0x06002706 RID: 9990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x783A", Offset = "0x783A", VA = "0x783A", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x783B", Offset = "0x783B", VA = "0x783B")]
		public SchoolController(SchoolModel model, Gameplay.MageSchool.Events.SchoolEvents events)
		{
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002708")]
		[Address(RVA = "0x783C", Offset = "0x783C", VA = "0x783C")]
		private void OnLearnSpellStartedEvent(ProtoLearnSpellStartedEvt msg)
		{
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002709")]
		[Address(RVA = "0x783D", Offset = "0x783D", VA = "0x783D")]
		private void OnLearnSpellAcceleratedEvent(ProtoLearnSpellAcceleratedEvt msg)
		{
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x783E", Offset = "0x783E", VA = "0x783E")]
		private void OnLearnSpellFinishedEvent(ProtoLearnSpellFinishedEvt msg)
		{
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x783F", Offset = "0x783F", VA = "0x783F")]
		private void ShowCompleteLearnSpellToast(SchoolSpellData spellData)
		{
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x7840", Offset = "0x7840", VA = "0x7840")]
		private void OnLearnSpellCanceledEvent(ProtoLearnSpellCanceledEvt msg)
		{
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x7841", Offset = "0x7841", VA = "0x7841")]
		public void LearnSpell(uint selectedSpell)
		{
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x7842", Offset = "0x7842", VA = "0x7842")]
		private void HandleStartLearnSpellService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x7843", Offset = "0x7843", VA = "0x7843")]
		public bool TryAccelerateSpell(uint spellId)
		{
			return default(bool);
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x7844", Offset = "0x7844", VA = "0x7844")]
		private void HandleAccelerateLearnSpellService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x7845", Offset = "0x7845", VA = "0x7845")]
		public void CancelSpell(uint selectedSpell)
		{
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x7846", Offset = "0x7846", VA = "0x7846")]
		private void Handler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x7847", Offset = "0x7847", VA = "0x7847")]
		public ResourceSet GetCancelImproveMonetBack(SchoolSpellData spell)
		{
			return null;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x7848", Offset = "0x7848", VA = "0x7848", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x7849", Offset = "0x7849", VA = "0x7849", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x784A", Offset = "0x784A", VA = "0x784A")]
		private IEnumerator HandleRunCoroutine()
		{
			return null;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x784B", Offset = "0x784B", VA = "0x784B")]
		private void ValidateInit()
		{
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x784C", Offset = "0x784C", VA = "0x784C")]
		public void GetSchoolInfo()
		{
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x784D", Offset = "0x784D", VA = "0x784D")]
		private void OnSchoolInfoLoaded(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0400155F RID: 5471
		[Token(Token = "0x400155F")]
		[FieldOffset(Offset = "0x18")]
		private SchoolService _schoolService;

		// Token: 0x04001560 RID: 5472
		[Token(Token = "0x4001560")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _handleRunCoroutineToken;

		// Token: 0x0200064A RID: 1610
		[Token(Token = "0x200064A")]
		public enum RequestFlag
		{
			// Token: 0x04001562 RID: 5474
			[Token(Token = "0x4001562")]
			UNKNOWN,
			// Token: 0x04001563 RID: 5475
			[Token(Token = "0x4001563")]
			LEARN_SPELL
		}
	}
}
