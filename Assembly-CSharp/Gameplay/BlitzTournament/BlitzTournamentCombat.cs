using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.BlitzTournament.Controller;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BlitzTournament
{
	// Token: 0x02000BBE RID: 3006
	[Token(Token = "0x2000BBE")]
	public class BlitzTournamentCombat : AbstractCombat<BlitzTournamentCombatModel, BlitzTournamentCombatEvents, BlitzTournamentCombatController, BlitzTournamentCombatMediator, OneOnOneCombatView>
	{
		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060049C0 RID: 18880 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060049C1 RID: 18881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE5")]
		public BlitzTournamentCombatEvents Events
		{
			[Token(Token = "0x60049C0")]
			[Address(RVA = "0x9832", Offset = "0x9832", VA = "0x9832")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60049C1")]
			[Address(RVA = "0x9833", Offset = "0x9833", VA = "0x9833")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x17000EE6")]
		public bool IsWaiting
		{
			[Token(Token = "0x60049C2")]
			[Address(RVA = "0x9834", Offset = "0x9834", VA = "0x9834")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x9835", Offset = "0x9835", VA = "0x9835", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x9836", Offset = "0x9836", VA = "0x9836", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C5")]
		[Address(RVA = "0x9837", Offset = "0x9837", VA = "0x9837")]
		public BlitzTournamentCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}
	}
}
