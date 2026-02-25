using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Gameplay.TutorialCombatV2.Control;
using Gameplay.TutorialCombatV2.Model;
using Gameplay.TutorialV2.Controller;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.TutorialCombatV2
{
	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	public class TutorialCombat : AbstractCombat<TutorialCombatModel, TutorialCombatEvents, TutorialCombatController, TutorialCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048A")]
		public TutorialCombatEvents Events
		{
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x6B59", Offset = "0x6B59", VA = "0x6B59")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x6B5A", Offset = "0x6B5A", VA = "0x6B5A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x6B5B", Offset = "0x6B5B", VA = "0x6B5B", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x6B5C", Offset = "0x6B5C", VA = "0x6B5C", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x6B5D", Offset = "0x6B5D", VA = "0x6B5D")]
		public TutorialCombat(TutorialStepsConveyor conveyor, IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0x2C")]
		public TutorialStepsConveyor _guideStepsConveyor;
	}
}
