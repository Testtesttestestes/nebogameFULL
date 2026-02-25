using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Inventory.View.Chest;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Cave;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Cave
{
	// Token: 0x02000B2B RID: 2859
	[Token(Token = "0x2000B2B")]
	public class CaveController : AbstractController<CaveModel, CaveEvents>
	{
		// Token: 0x0600457D RID: 17789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x9421", Offset = "0x9421", VA = "0x9421")]
		public CaveController(CaveModel model, CaveEvents events)
		{
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457E")]
		[Address(RVA = "0x9422", Offset = "0x9422", VA = "0x9422", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x9423", Offset = "0x9423", VA = "0x9423")]
		private void BuildingStateChangedEvent(uint buildingType)
		{
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004580")]
		[Address(RVA = "0x9424", Offset = "0x9424", VA = "0x9424")]
		private void ValidateSearchPrice()
		{
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004581")]
		[Address(RVA = "0x9425", Offset = "0x9425", VA = "0x9425")]
		private void HandleServiceEventNewMonsterInCave(ProtoGetCaveInfoAns msg)
		{
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004582")]
		[Address(RVA = "0x9426", Offset = "0x9426", VA = "0x9426", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004583")]
		[Address(RVA = "0x9427", Offset = "0x9427", VA = "0x9427")]
		public void RequestSearchCave()
		{
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004584")]
		[Address(RVA = "0x9428", Offset = "0x9428", VA = "0x9428")]
		private void OnSearchCaveAns(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004585")]
		[Address(RVA = "0x9429", Offset = "0x9429", VA = "0x9429")]
		private void HandleCaveState(List<RewardInfo> rewards, uint monsterId, IList<ArtikulStackSize> monsterArtikuls, bool monsterStatusConfirmed)
		{
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004586")]
		[Address(RVA = "0x942A", Offset = "0x942A", VA = "0x942A")]
		private void GetCaveInfo()
		{
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004587")]
		[Address(RVA = "0x942B", Offset = "0x942B", VA = "0x942B")]
		private void OnCaveInfoAns(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x942C", Offset = "0x942C", VA = "0x942C")]
		private void OnGetCaveInfo(ProtoGetCaveInfoAns msg)
		{
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004589")]
		[Address(RVA = "0x942D", Offset = "0x942D", VA = "0x942D")]
		public void AttackMonster(MonsterData monster)
		{
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458A")]
		[Address(RVA = "0x942E", Offset = "0x942E", VA = "0x942E")]
		public void KickMonster()
		{
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x942F", Offset = "0x942F", VA = "0x942F")]
		private void AttackSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x9430", Offset = "0x9430", VA = "0x9430")]
		private void HandleMonsterKickService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458D")]
		[Address(RVA = "0x9431", Offset = "0x9431", VA = "0x9431")]
		public void OpenInventory()
		{
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x9432", Offset = "0x9432", VA = "0x9432")]
		public static bool FilterCaveArtifacts(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x04002604 RID: 9732
		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x18")]
		private CaveService _caveService;

		// Token: 0x04002605 RID: 9733
		[Token(Token = "0x4002605")]
		[FieldOffset(Offset = "0x1C")]
		private CommandsRepository _commandsRepository;

		// Token: 0x04002606 RID: 9734
		[Token(Token = "0x4002606")]
		[FieldOffset(Offset = "0x20")]
		private uint _waitingConfirmationMonsterId;

		// Token: 0x04002607 RID: 9735
		[Token(Token = "0x4002607")]
		[FieldOffset(Offset = "0x24")]
		private UserInventoryChestWindow _inventoryChestWindow;

		// Token: 0x04002608 RID: 9736
		[Token(Token = "0x4002608")]
		[FieldOffset(Offset = "0x0")]
		private static List<uint> _caveArtikulTypes;
	}
}
