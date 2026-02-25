using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Gameplay.Tournaments.Controller;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Tournaments
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	public class TournamentCombat : AbstractCombat<TournamentCombatModel, TournamentCombatEvents, TournamentCombatController, TournamentCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EC")]
		public TournamentCombatEvents Events
		{
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0x6D7E", Offset = "0x6D7E", VA = "0x6D7E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x6D7F", Offset = "0x6D7F", VA = "0x6D7F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x170004ED")]
		public bool IsWaiting
		{
			[Token(Token = "0x6001C01")]
			[Address(RVA = "0x6D80", Offset = "0x6D80", VA = "0x6D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x6D81", Offset = "0x6D81", VA = "0x6D81", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x6D82", Offset = "0x6D82", VA = "0x6D82", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x6D83", Offset = "0x6D83", VA = "0x6D83")]
		public TournamentCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}
	}
}
