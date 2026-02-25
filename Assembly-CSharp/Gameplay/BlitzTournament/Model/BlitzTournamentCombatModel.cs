using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BlitzTournament.Model
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x2000BD1")]
	public class BlitzTournamentCombatModel : CombatModel
	{
		// Token: 0x06004A1F RID: 18975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x9881", Offset = "0x9881", VA = "0x9881")]
		public BlitzTournamentCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06004A20 RID: 18976 RVA: 0x0000DA58 File Offset: 0x0000BC58
		// (set) Token: 0x06004A21 RID: 18977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EFE")]
		public ulong LoserId
		{
			[Token(Token = "0x6004A20")]
			[Address(RVA = "0x9882", Offset = "0x9882", VA = "0x9882")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004A21")]
			[Address(RVA = "0x9883", Offset = "0x9883", VA = "0x9883")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06004A22 RID: 18978 RVA: 0x0000DA70 File Offset: 0x0000BC70
		// (set) Token: 0x06004A23 RID: 18979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EFF")]
		public ulong WinnerId
		{
			[Token(Token = "0x6004A22")]
			[Address(RVA = "0x9884", Offset = "0x9884", VA = "0x9884")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004A23")]
			[Address(RVA = "0x9885", Offset = "0x9885", VA = "0x9885")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06004A24 RID: 18980 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x17000F00")]
		public ulong OpponentId
		{
			[Token(Token = "0x6004A24")]
			[Address(RVA = "0x9886", Offset = "0x9886", VA = "0x9886")]
			get
			{
				return 0UL;
			}
		}
	}
}
