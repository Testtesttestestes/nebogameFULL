using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Boss.Model;
using Gameplay.BossCombat.Controller;
using Gameplay.BossCombat.Model;
using Gameplay.Combat;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BossCombat
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	public class BossCombat : AbstractCombat<BossCombatModel, BossCombatEvents, BossCombatController, BossCombatViewMediator, OneOnOneCombatView>
	{
		// Token: 0x060045BA RID: 17850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x945C", Offset = "0x945C", VA = "0x945C", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045BC RID: 17852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBE")]
		public BossInstanceModel BossInstanceModel
		{
			[Token(Token = "0x60045BB")]
			[Address(RVA = "0x945D", Offset = "0x945D", VA = "0x945D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045BC")]
			[Address(RVA = "0x945E", Offset = "0x945E", VA = "0x945E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045BE RID: 17854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBF")]
		public BossCombatEvents Events
		{
			[Token(Token = "0x60045BD")]
			[Address(RVA = "0x945F", Offset = "0x945F", VA = "0x945F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045BE")]
			[Address(RVA = "0x9460", Offset = "0x9460", VA = "0x9460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x9461", Offset = "0x9461", VA = "0x9461", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x9462", Offset = "0x9462", VA = "0x9462")]
		public BossCombat(IGame game, BossInstanceModel bossInstanceModel, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}
	}
}
