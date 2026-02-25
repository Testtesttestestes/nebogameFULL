using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.World.Model
{
	// Token: 0x02000368 RID: 872
	[Token(Token = "0x2000368")]
	public class ClanCurseData
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x65F3", Offset = "0x65F3", VA = "0x65F3")]
		public ClanCurseData(ClanRestrictionInfo info, Dictionaries dict)
		{
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033C")]
		public ClanRestrictionDic ClanRestrictionDic
		{
			[Token(Token = "0x6001418")]
			[Address(RVA = "0x65F4", Offset = "0x65F4", VA = "0x65F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001419")]
			[Address(RVA = "0x65F5", Offset = "0x65F5", VA = "0x65F5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033D")]
		public BackTime BackTime
		{
			[Token(Token = "0x600141A")]
			[Address(RVA = "0x65F6", Offset = "0x65F6", VA = "0x65F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600141B")]
			[Address(RVA = "0x65F7", Offset = "0x65F7", VA = "0x65F7")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
