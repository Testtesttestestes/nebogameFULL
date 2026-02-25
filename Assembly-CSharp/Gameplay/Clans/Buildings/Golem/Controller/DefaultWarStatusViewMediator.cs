using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000AD8 RID: 2776
	[Token(Token = "0x2000AD8")]
	public class DefaultWarStatusViewMediator : AbstractViewMediator<GolemModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x060042D5 RID: 17109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x9189", Offset = "0x9189", VA = "0x9189")]
		public DefaultWarStatusViewMediator(GolemModel model, ClanWarsEvents events, ClanWarsController controller)
		{
		}

		// Token: 0x17000D34 RID: 3380
		// (set) Token: 0x060042D6 RID: 17110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D34")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x60042D6")]
			[Address(RVA = "0x918A", Offset = "0x918A", VA = "0x918A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x918B", Offset = "0x918B", VA = "0x918B")]
		private void Init()
		{
		}
	}
}
