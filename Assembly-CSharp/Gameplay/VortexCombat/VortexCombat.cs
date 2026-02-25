using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.VortexCombat.Control;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.VortexCombat
{
	// Token: 0x020003A3 RID: 931
	[Token(Token = "0x20003A3")]
	public class VortexCombat : AbstractCombat<VortexCombatModel, VortexCombatEvents, VortexCombatController, VortexCombatViewMediator, VortexCombatView>
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x17000396")]
		public bool Avail
		{
			[Token(Token = "0x60015BD")]
			[Address(RVA = "0x677F", Offset = "0x677F", VA = "0x677F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x6780", Offset = "0x6780", VA = "0x6780", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x6781", Offset = "0x6781", VA = "0x6781", Slot = "12")]
		protected override bool CheckRunRestrictions()
		{
			return default(bool);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x6782", Offset = "0x6782", VA = "0x6782")]
		public VortexCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x28")]
		public readonly int[] LevelRangeForAvail;
	}
}
