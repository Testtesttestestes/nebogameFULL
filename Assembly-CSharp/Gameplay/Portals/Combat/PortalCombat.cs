using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Portals.Combat.Control;
using Gameplay.Portals.Combat.Model;
using Gameplay.Portals.Combat.View;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Gameplay.Portals.Combat
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	public class PortalCombat : AbstractCombat<PortalCombatModel, PortalCombatEvents, PortalCombatController, PortalCombatViewMediator, PortalCombatView>
	{
		// Token: 0x060024BD RID: 9405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x760B", Offset = "0x760B", VA = "0x760B")]
		public PortalCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x760C", Offset = "0x760C", VA = "0x760C", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x760D", Offset = "0x760D", VA = "0x760D")]
		public static bool TryRun(IGame game, ResourceSet cost)
		{
			return default(bool);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x760E", Offset = "0x760E", VA = "0x760E")]
		public static ICombat Run(IGame game)
		{
			return null;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60024C1")]
		[Address(RVA = "0x760F", Offset = "0x760F", VA = "0x760F")]
		public static ICombat Run(IGame game, BackTime backTime)
		{
			return null;
		}
	}
}
