using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000AE3 RID: 2787
	[Token(Token = "0x2000AE3")]
	public class WarStatusViewMasterMediator : AbstractViewMediator<ClanWarsModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x06004333 RID: 17203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004333")]
		[Address(RVA = "0x91E7", Offset = "0x91E7", VA = "0x91E7")]
		public WarStatusViewMasterMediator(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, GolemModel golemModel)
		{
		}

		// Token: 0x17000D3D RID: 3389
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3D")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x6004334")]
			[Address(RVA = "0x91E8", Offset = "0x91E8", VA = "0x91E8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004335")]
		[Address(RVA = "0x91E9", Offset = "0x91E9", VA = "0x91E9")]
		private void CombatButtonClickedEventHandler()
		{
		}

		// Token: 0x17000D3E RID: 3390
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3E")]
		private GolemModel GolemModel
		{
			[Token(Token = "0x6004336")]
			[Address(RVA = "0x91EA", Offset = "0x91EA", VA = "0x91EA")]
			set
			{
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (set) Token: 0x06004337 RID: 17207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3F")]
		public override ClanWarsEvents Events
		{
			[Token(Token = "0x6004337")]
			[Address(RVA = "0x91EB", Offset = "0x91EB", VA = "0x91EB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004338")]
		[Address(RVA = "0x91EC", Offset = "0x91EC", VA = "0x91EC")]
		private void WarStateChangedEventHandler()
		{
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004339")]
		[Address(RVA = "0x91ED", Offset = "0x91ED", VA = "0x91ED")]
		private void GolemStateChangedEventHandler()
		{
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433A")]
		[Address(RVA = "0x91EE", Offset = "0x91EE", VA = "0x91EE")]
		private void Init()
		{
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433B")]
		[Address(RVA = "0x91EF", Offset = "0x91EF", VA = "0x91EF")]
		private void UpdateState()
		{
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433C")]
		[Address(RVA = "0x91F0", Offset = "0x91F0", VA = "0x91F0", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x18")]
		private GolemModel _golemModel;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0x1C")]
		private IViewMediator<WarStatusWindow> _currentMediator;
	}
}
