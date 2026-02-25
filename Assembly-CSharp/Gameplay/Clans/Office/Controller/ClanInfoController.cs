using System;
using Core.Data;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Common;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A66 RID: 2662
	[Token(Token = "0x2000A66")]
	public class ClanInfoController : AbstractController<ClanInfoModel, ClanInfoEvents>
	{
		// Token: 0x06003EE4 RID: 16100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE4")]
		[Address(RVA = "0x8DA0", Offset = "0x8DA0", VA = "0x8DA0")]
		public ClanInfoController(ClanInfoModel model, ClanInfoEvents events, ClansController clansController)
		{
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE5")]
		[Address(RVA = "0x8DA1", Offset = "0x8DA1", VA = "0x8DA1")]
		public void GetClanIsleInfo()
		{
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE6")]
		[Address(RVA = "0x8DA2", Offset = "0x8DA2", VA = "0x8DA2")]
		private void GetIsleInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE7")]
		[Address(RVA = "0x8DA3", Offset = "0x8DA3", VA = "0x8DA3")]
		public void GetMembersList(ulong clanId)
		{
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE8")]
		[Address(RVA = "0x8DA4", Offset = "0x8DA4", VA = "0x8DA4")]
		private void GetMembersListResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x8DA5", Offset = "0x8DA5", VA = "0x8DA5")]
		public void RequestJoinClan()
		{
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x8DA6", Offset = "0x8DA6", VA = "0x8DA6")]
		private void RequestJoinClanResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x8DA7", Offset = "0x8DA7", VA = "0x8DA7")]
		public void CancelJoinRequest()
		{
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x8DA8", Offset = "0x8DA8", VA = "0x8DA8")]
		private void CancelJoinRequestResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x8DA9", Offset = "0x8DA9", VA = "0x8DA9")]
		public void ChangeClan(string name, string description, bool isFraction, ResourceSet price)
		{
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x8DAA", Offset = "0x8DAA", VA = "0x8DAA")]
		private void ChangeClanInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x8DAB", Offset = "0x8DAB", VA = "0x8DAB")]
		public void AppointHead(UserData user)
		{
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x8DAC", Offset = "0x8DAC", VA = "0x8DAC")]
		private void RequestAppointHead(UserData user)
		{
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x8DAD", Offset = "0x8DAD", VA = "0x8DAD")]
		private void AppointHeadResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF2")]
		[Address(RVA = "0x8DAE", Offset = "0x8DAE", VA = "0x8DAE")]
		public void AddVacancy()
		{
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF3")]
		[Address(RVA = "0x8DAF", Offset = "0x8DAF", VA = "0x8DAF")]
		private void AddVacancyResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF4")]
		[Address(RVA = "0x8DB0", Offset = "0x8DB0", VA = "0x8DB0")]
		public void SetClanStateFlags(uint flags)
		{
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x8DB1", Offset = "0x8DB1", VA = "0x8DB1")]
		private void SetClanStateFlagsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF6")]
		[Address(RVA = "0x8DB2", Offset = "0x8DB2", VA = "0x8DB2")]
		public void AddToTreasury(ResourceSet resourceSet)
		{
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF7")]
		[Address(RVA = "0x8DB3", Offset = "0x8DB3", VA = "0x8DB3")]
		private void AddToTreasuryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x8DB4", Offset = "0x8DB4", VA = "0x8DB4")]
		public void DisbandClan()
		{
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x8DB5", Offset = "0x8DB5", VA = "0x8DB5")]
		public void LeaveClan()
		{
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x1B12", Offset = "0x1B12", VA = "0x1B12")]
		public DialogWindow ShowFeeTooSmallDialogWindow()
		{
			return null;
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x8DB6", Offset = "0x8DB6", VA = "0x8DB6")]
		public DialogWindow ShowAppintHeadDialogWindow(UserData user)
		{
			return null;
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFC")]
		[Address(RVA = "0x8DB7", Offset = "0x8DB7", VA = "0x8DB7", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0x8DB8", Offset = "0x8DB8", VA = "0x8DB8", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x8DB9", Offset = "0x8DB9", VA = "0x8DB9")]
		private void HandleUserBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0x8DBA", Offset = "0x8DBA", VA = "0x8DBA")]
		private void ClanUnregisteredHandler(ProtoUnregisterClanAns ans)
		{
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F00")]
		[Address(RVA = "0x8DBB", Offset = "0x8DBB", VA = "0x8DBB")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x0400237C RID: 9084
		[Token(Token = "0x400237C")]
		[FieldOffset(Offset = "0x18")]
		public readonly ClansController ClansController;

		// Token: 0x0400237D RID: 9085
		[Token(Token = "0x400237D")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ClanIsleService _clanIsleService;

		// Token: 0x0400237E RID: 9086
		[Token(Token = "0x400237E")]
		[FieldOffset(Offset = "0x20")]
		private readonly ClansService _clansService;

		// Token: 0x0400237F RID: 9087
		[Token(Token = "0x400237F")]
		[FieldOffset(Offset = "0x24")]
		private readonly CommandsRepository _commandsRepository;
	}
}
