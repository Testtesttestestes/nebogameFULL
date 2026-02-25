using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Clans.ClanWars;
using Gameplay.Clans.Combat.Control;
using Gameplay.Clans.Combat.Model;
using Gameplay.Clans.Combat.View;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Gameplay.Clans.Combat
{
	// Token: 0x02000A8E RID: 2702
	[Token(Token = "0x2000A8E")]
	public class ClanCombat : AbstractCombat<ClanCombatModel, ClanCombatEvents, ClanCombatController, ClanCombatViewMediator, ClanCombatView>
	{
		// Token: 0x060040CB RID: 16587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CB")]
		[Address(RVA = "0x8F82", Offset = "0x8F82", VA = "0x8F82", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CC")]
		[Address(RVA = "0x8F83", Offset = "0x8F83", VA = "0x8F83")]
		public ClanCombat(IGame game, ClanCombat.ClanCombatArgs args, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CD")]
		[Address(RVA = "0x8F84", Offset = "0x8F84", VA = "0x8F84", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x60040CE")]
		[Address(RVA = "0x8F85", Offset = "0x8F85", VA = "0x8F85")]
		public static bool TryRunViewMode(IGame game)
		{
			return default(bool);
		}

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x28")]
		public ClanCombat.ClanCombatArgs Args;

		// Token: 0x02000A8F RID: 2703
		[Token(Token = "0x2000A8F")]
		public class ClanCombatArgs
		{
			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x060040CF RID: 16591 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060040D0 RID: 16592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CC3")]
			public IClanWars ClanWars
			{
				[Token(Token = "0x60040CF")]
				[Address(RVA = "0x8F86", Offset = "0x8F86", VA = "0x8F86")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60040D0")]
				[Address(RVA = "0x8F87", Offset = "0x8F87", VA = "0x8F87")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060040D1 RID: 16593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040D1")]
			[Address(RVA = "0x8F88", Offset = "0x8F88", VA = "0x8F88")]
			public ClanCombatArgs(IClanWars model, bool isViewMode)
			{
			}

			// Token: 0x060040D2 RID: 16594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040D2")]
			[Address(RVA = "0x8F89", Offset = "0x8F89", VA = "0x8F89")]
			public ClanCombatArgs(IClanWars model)
			{
			}

			// Token: 0x040023F3 RID: 9203
			[Token(Token = "0x40023F3")]
			[FieldOffset(Offset = "0xC")]
			public readonly bool IsViewMode;
		}
	}
}
