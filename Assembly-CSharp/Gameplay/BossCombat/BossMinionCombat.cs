using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.BossCombat.Controller;
using Gameplay.BossCombat.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BossCombat
{
	// Token: 0x02000B38 RID: 2872
	[Token(Token = "0x2000B38")]
	public class BossMinionCombat : AbstractCombat<BossMinionCombatModel, BossMinionCombatEvents, BossMinionCombatController, BossMinionCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045C3 RID: 17859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC0")]
		public BossMinionCombatEvents Events
		{
			[Token(Token = "0x60045C2")]
			[Address(RVA = "0x9464", Offset = "0x9464", VA = "0x9464")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045C3")]
			[Address(RVA = "0x9465", Offset = "0x9465", VA = "0x9465")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x9466", Offset = "0x9466", VA = "0x9466", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x9467", Offset = "0x9467", VA = "0x9467")]
		public BossMinionCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}
	}
}
