using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Il2CppDummyDll;
using MVC;
using UI.Tabs;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BBB RID: 3003
	[Token(Token = "0x2000BBB")]
	public class BossWindowMediator : AbstractViewMediator<BossInstanceModel, BossInstanceEvents, BossInstanceController, BossWindow>
	{
		// Token: 0x060049AA RID: 18858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AA")]
		[Address(RVA = "0x981C", Offset = "0x981C", VA = "0x981C")]
		public BossWindowMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x17000EE1 RID: 3809
		// (set) Token: 0x060049AB RID: 18859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE1")]
		public override BossInstanceEvents Events
		{
			[Token(Token = "0x60049AB")]
			[Address(RVA = "0x981D", Offset = "0x981D", VA = "0x981D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AC")]
		[Address(RVA = "0x981E", Offset = "0x981E", VA = "0x981E")]
		private void MyTeamsInfoChangedEvent()
		{
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AD")]
		[Address(RVA = "0x981F", Offset = "0x981F", VA = "0x981F")]
		private void CaptainInvitesChangedEvent()
		{
		}

		// Token: 0x17000EE2 RID: 3810
		// (set) Token: 0x060049AE RID: 18862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE2")]
		public override BossWindow View
		{
			[Token(Token = "0x60049AE")]
			[Address(RVA = "0x9820", Offset = "0x9820", VA = "0x9820", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049AF")]
		[Address(RVA = "0x9821", Offset = "0x9821", VA = "0x9821")]
		private void ResetView()
		{
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x9822", Offset = "0x9822", VA = "0x9822")]
		private void SetupView()
		{
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x9823", Offset = "0x9823", VA = "0x9823")]
		private void ValidateTabCounters()
		{
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B2")]
		[Address(RVA = "0x9824", Offset = "0x9824", VA = "0x9824")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x9825", Offset = "0x9825", VA = "0x9825")]
		private List<TabBarItemData> GetTabBarData(out int? indexOfDefaultTab)
		{
			return null;
		}
	}
}
