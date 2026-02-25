using System;
using System.Collections.Generic;
using Gameplay.WorldAxis.ClanEquipment.Events;
using Gameplay.WorldAxis.ClanEquipment.Model;
using Gameplay.WorldAxis.ClanEquipment.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Dic;

namespace Gameplay.WorldAxis.ClanEquipment.Controller
{
	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	public class ClanEquipmentViewMediator : AbstractViewMediator<ClanEquipmentModel, ClanEquipmentEvents, ClanEquipmentController, ClanEquipmentWindow>
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x655D", Offset = "0x655D", VA = "0x655D")]
		public ClanEquipmentViewMediator(ClanEquipmentModel model, ClanEquipmentEvents events, ClanEquipmentController controller)
		{
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x655E", Offset = "0x655E", VA = "0x655E")]
		private bool DefaultListPredicate(ClanMemberDollsListElement.ClanMemberDollsListElementArgs args)
		{
			return default(bool);
		}

		// Token: 0x1700030B RID: 779
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030B")]
		public override ClanEquipmentWindow View
		{
			[Token(Token = "0x600136F")]
			[Address(RVA = "0x655F", Offset = "0x655F", VA = "0x655F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x6560", Offset = "0x6560", VA = "0x6560")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x6561", Offset = "0x6561", VA = "0x6561")]
		private void Init()
		{
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x6562", Offset = "0x6562", VA = "0x6562")]
		private void OnlyEquippedToggledEventHandler(bool enabled)
		{
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x6563", Offset = "0x6563", VA = "0x6563")]
		private void FilterDeselectedEventHandler()
		{
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x6564", Offset = "0x6564", VA = "0x6564")]
		private void FilterSelectedEventHandler(object obj)
		{
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x6565", Offset = "0x6565", VA = "0x6565")]
		private void TakeOffAllButtonClickedEventHandler()
		{
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x6566", Offset = "0x6566", VA = "0x6566")]
		private void ExpellButtonClickedEventHandler()
		{
		}

		// Token: 0x1700030C RID: 780
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		public override ClanEquipmentEvents Events
		{
			[Token(Token = "0x6001377")]
			[Address(RVA = "0x6567", Offset = "0x6567", VA = "0x6567", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x6568", Offset = "0x6568", VA = "0x6568")]
		private void DataChangedEventHandler()
		{
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x6569", Offset = "0x6569", VA = "0x6569")]
		private void DollArtifactsRequestedEventHandler()
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x656A", Offset = "0x656A", VA = "0x656A")]
		private void RenderList()
		{
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x656B", Offset = "0x656B", VA = "0x656B")]
		private ClanMemberDollsListElement.ClanMemberDollsListElementArgs ConstructArgs(ClanEquipmentModel.DollsOwner dollOwner)
		{
			return null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x656C", Offset = "0x656C", VA = "0x656C")]
		private void ListElementClickedEventHandler(ClanMemberDollsListElement element)
		{
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x656D", Offset = "0x656D", VA = "0x656D")]
		private void Select(ClanMemberDollsListElement.ClanMemberDollsListElementArgs args)
		{
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x656E", Offset = "0x656E", VA = "0x656E")]
		private void RenderArtifacts()
		{
		}

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x18")]
		private ClanMemberDollsListElement.ClanMemberDollsListElementArgs _selectedArgs;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x1C")]
		private DollsInfoDic _selectedFilter;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x20")]
		private Func<ClanMemberDollsListElement.ClanMemberDollsListElementArgs, bool> _predicate;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x24")]
		private readonly HashSet<ulong> _removedUsers;
	}
}
