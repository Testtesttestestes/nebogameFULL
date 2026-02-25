using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Duel.Controller;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Duel
{
	// Token: 0x02000853 RID: 2131
	[Token(Token = "0x2000853")]
	public class DuelCombat : AbstractCombat<CombatModel, CombatEvents, DuelCombatController, DuelCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x170009E3")]
		public bool IsWaiting
		{
			[Token(Token = "0x6003228")]
			[Address(RVA = "0x827E", Offset = "0x827E", VA = "0x827E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003229")]
		[Address(RVA = "0x827F", Offset = "0x827F", VA = "0x827F", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600322A")]
		[Address(RVA = "0x8280", Offset = "0x8280", VA = "0x8280")]
		public DuelCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime, bool isDefender)
		{
		}

		// Token: 0x04001B68 RID: 7016
		[Token(Token = "0x4001B68")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _isDefender;
	}
}
