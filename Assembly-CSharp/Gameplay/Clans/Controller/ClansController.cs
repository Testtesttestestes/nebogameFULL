using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Gameplay.Clans.Events;
using Gameplay.Clans.Model;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Chat;
using Protocol.ClanIsle;
using Protocol.Clans;
using Protocol.Common;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;

namespace Gameplay.Clans.Controller
{
	// Token: 0x02000A8D RID: 2701
	[Token(Token = "0x2000A8D")]
	public class ClansController : AbstractController<ClansModel, Gameplay.Clans.Events.ClansEvents>
	{
		// Token: 0x060040AD RID: 16557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x8F64", Offset = "0x8F64", VA = "0x8F64")]
		public ClansController(ClansModel model, Gameplay.Clans.Events.ClansEvents events)
		{
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x8F65", Offset = "0x8F65", VA = "0x8F65")]
		public void AssignNewClanToUser()
		{
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x8F66", Offset = "0x8F66", VA = "0x8F66")]
		public void DissociateClanFromUser()
		{
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x8F67", Offset = "0x8F67", VA = "0x8F67")]
		private void GetOwnClanInfo()
		{
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x8F68", Offset = "0x8F68", VA = "0x8F68")]
		private void GetOwnClanInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x8F69", Offset = "0x8F69", VA = "0x8F69")]
		private void GetClanTreasury()
		{
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x8F6A", Offset = "0x8F6A", VA = "0x8F6A")]
		private void GetClanTreasuryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x8F6B", Offset = "0x8F6B", VA = "0x8F6B")]
		public void UpdateClanTreasury()
		{
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x8F6C", Offset = "0x8F6C", VA = "0x8F6C")]
		private void UpdateClanTreasuryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x8F6D", Offset = "0x8F6D", VA = "0x8F6D")]
		public void KickMember(UserData userData)
		{
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x8F6E", Offset = "0x8F6E", VA = "0x8F6E")]
		private void KickMemberResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x8F6F", Offset = "0x8F6F", VA = "0x8F6F")]
		public void LeaveClan()
		{
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x8F70", Offset = "0x8F70", VA = "0x8F70")]
		private void LeaveClanResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x8F71", Offset = "0x8F71", VA = "0x8F71", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x8F72", Offset = "0x8F72", VA = "0x8F72", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x8F73", Offset = "0x8F73", VA = "0x8F73")]
		private void TriggerChangedEventHandler(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x8F74", Offset = "0x8F74", VA = "0x8F74")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x8F75", Offset = "0x8F75", VA = "0x8F75")]
		private void UserInfoChangedEventHandler(ProtoUserInfoChangedEvt evt)
		{
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x8F76", Offset = "0x8F76", VA = "0x8F76")]
		public void DisbandClan(ClanData clanData)
		{
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x8F77", Offset = "0x8F77", VA = "0x8F77")]
		private void UnregisterClanResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x8F78", Offset = "0x8F78", VA = "0x8F78")]
		private void ClanLeaderChangedEventHandler(ProtoClanLeaderChangedEvt evt)
		{
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x8F79", Offset = "0x8F79", VA = "0x8F79")]
		private void HandleCurrentIsleChangedEvent(ulong id)
		{
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x8F7A", Offset = "0x8F7A", VA = "0x8F7A")]
		private void TreasuryChangedEventHandler(ProtoTreasuryChangedEvt evt)
		{
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x8F7B", Offset = "0x8F7B", VA = "0x8F7B")]
		private void NewClanAssignedEventHandler([Optional] ProtoTreasuryChangedEvt evt)
		{
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C5")]
		[Address(RVA = "0x8F7C", Offset = "0x8F7C", VA = "0x8F7C")]
		private void HandleInit()
		{
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x8F7D", Offset = "0x8F7D", VA = "0x8F7D")]
		private void AssignClanIsleToUser(ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInfo)
		{
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x8F7E", Offset = "0x8F7E", VA = "0x8F7E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x8F7F", Offset = "0x8F7F", VA = "0x8F7F")]
		[CompilerGenerated]
		private void <HandleInit>g__GetOwnClanIsleInfo|26_0(ulong clanId, uint flags)
		{
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C9")]
		[Address(RVA = "0x8F80", Offset = "0x8F80", VA = "0x8F80")]
		[CompilerGenerated]
		private void <HandleInit>g__GetOwnClanIsleInfoResultHandler|26_1(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CA")]
		[Address(RVA = "0x8F81", Offset = "0x8F81", VA = "0x8F81")]
		[CompilerGenerated]
		private void <AssignClanIsleToUser>g__GetShortClanInfoResultHandler|27_0(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ClansService _clansService;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private ClanIsleService _clanIsleService;
	}
}
