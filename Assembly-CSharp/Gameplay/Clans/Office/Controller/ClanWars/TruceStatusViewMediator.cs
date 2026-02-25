using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	public class TruceStatusViewMediator : AbstractViewMediator<ClanWarsModel, ClanWarsEvents, ClanWarsController, ClanWarStatusView>, IViewMediator<ClanWarStatusView>, IViewMediator
	{
		// Token: 0x06004081 RID: 16513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004081")]
		[Address(RVA = "0x8F3B", Offset = "0x8F3B", VA = "0x8F3B")]
		public TruceStatusViewMediator(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, ClanPolicyListElement.ClanPolicyListElementArgs args)
		{
		}

		// Token: 0x17000CB9 RID: 3257
		// (set) Token: 0x06004082 RID: 16514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB9")]
		public override ClanWarStatusView View
		{
			[Token(Token = "0x6004082")]
			[Address(RVA = "0x8F3C", Offset = "0x8F3C", VA = "0x8F3C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x8F3D", Offset = "0x8F3D", VA = "0x8F3D")]
		private void Init()
		{
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004084")]
		[Address(RVA = "0x8F3E", Offset = "0x8F3E", VA = "0x8F3E")]
		private void SetNotInWarStatus(int error)
		{
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x8F3F", Offset = "0x8F3F", VA = "0x8F3F")]
		private void AttackButtonClickedEventHandler()
		{
		}

		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0x18")]
		private ClanPolicyListElement.ClanPolicyListElementArgs _args;
	}
}
