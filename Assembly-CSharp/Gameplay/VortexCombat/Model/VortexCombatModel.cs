using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Partycombat;
using Utils;

namespace Gameplay.VortexCombat.Model
{
	// Token: 0x020003B1 RID: 945
	[Token(Token = "0x20003B1")]
	public class VortexCombatModel : TeamCombatModel
	{
		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x170003AE")]
		public override int SpellSlotsCount
		{
			[Token(Token = "0x6001621")]
			[Address(RVA = "0x67E2", Offset = "0x67E2", VA = "0x67E2", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x170003AF")]
		public override int ElixirsSlotsCount
		{
			[Token(Token = "0x6001622")]
			[Address(RVA = "0x67E3", Offset = "0x67E3", VA = "0x67E3", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x000053D0 File Offset: 0x000035D0
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B0")]
		public bool SkillNumbersOnBarsEnabled
		{
			[Token(Token = "0x6001623")]
			[Address(RVA = "0x67E4", Offset = "0x67E4", VA = "0x67E4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x67E5", Offset = "0x67E5", VA = "0x67E5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x170003B1")]
		public virtual CombatTypes CombatType
		{
			[Token(Token = "0x6001625")]
			[Address(RVA = "0x67E6", Offset = "0x67E6", VA = "0x67E6", Slot = "19")]
			get
			{
				return CombatTypes.UnknownCombat;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B2")]
		public virtual long[] CombatParams
		{
			[Token(Token = "0x6001626")]
			[Address(RVA = "0x67E7", Offset = "0x67E7", VA = "0x67E7", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x67E8", Offset = "0x67E8", VA = "0x67E8", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x67E9", Offset = "0x67E9", VA = "0x67E9")]
		public VortexCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B3")]
		public override CombatPlayer MyPlayer
		{
			[Token(Token = "0x6001629")]
			[Address(RVA = "0x67EA", Offset = "0x67EA", VA = "0x67EA", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x67EB", Offset = "0x67EB", VA = "0x67EB")]
		public void SetRequestCombatData(Protocol.Partycombat.ProtoRequestCombatAns value)
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x67EC", Offset = "0x67EC", VA = "0x67EC", Slot = "10")]
		public override TurnStates GetTurnState(ulong userId)
		{
			return TurnStates.NoTurn;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x67ED", Offset = "0x67ED", VA = "0x67ED", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
			return null;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x67EE", Offset = "0x67EE", VA = "0x67EE", Slot = "13")]
		protected override CombatEventData CreateCombatEventData(CombatEventDic dict)
		{
			return null;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x67EF", Offset = "0x67EF", VA = "0x67EF", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
			return null;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x67F0", Offset = "0x67F0", VA = "0x67F0", Slot = "14")]
		public override bool GetSpellsEnabled(ulong userId)
		{
			return default(bool);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x67F1", Offset = "0x67F1", VA = "0x67F1", Slot = "21")]
		public virtual void GetAwaitText(out string title, out string description)
		{
		}

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4000BBB")]
		[FieldOffset(Offset = "0x60")]
		private Protocol.Partycombat.ProtoRequestCombatAns _requestOfCombat;
	}
}
