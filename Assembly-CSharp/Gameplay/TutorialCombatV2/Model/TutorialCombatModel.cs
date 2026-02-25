using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.TutorialCombatV2.Model
{
	// Token: 0x02000451 RID: 1105
	[Token(Token = "0x2000451")]
	public class TutorialCombatModel : CombatModel
	{
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00005A30 File Offset: 0x00003C30
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000497")]
		public bool CombatOnPause
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x6BC7", Offset = "0x6BC7", VA = "0x6BC7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x6BC8", Offset = "0x6BC8", VA = "0x6BC8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A32")]
		[Address(RVA = "0x6BC9", Offset = "0x6BC9", VA = "0x6BC9")]
		public TutorialCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}
	}
}
