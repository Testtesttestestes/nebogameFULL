using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Tournaments.Model
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	public class TournamentCombatModel : CombatModel
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00005F58 File Offset: 0x00004158
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000522")]
		public ulong ViewedUserId
		{
			[Token(Token = "0x6001C83")]
			[Address(RVA = "0x6E02", Offset = "0x6E02", VA = "0x6E02")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C84")]
			[Address(RVA = "0x6E03", Offset = "0x6E03", VA = "0x6E03")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x17000523")]
		public bool ViewerMode
		{
			[Token(Token = "0x6001C85")]
			[Address(RVA = "0x6E04", Offset = "0x6E04", VA = "0x6E04")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x6E05", Offset = "0x6E05", VA = "0x6E05")]
		public TournamentCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}
	}
}
