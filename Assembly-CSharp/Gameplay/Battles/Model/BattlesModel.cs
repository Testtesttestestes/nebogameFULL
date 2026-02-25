using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.Battles.Model
{
	// Token: 0x02000C2C RID: 3116
	[Token(Token = "0x2000C2C")]
	public class BattlesModel : AbstractModel
	{
		// Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x9A3F", Offset = "0x9A3F", VA = "0x9A3F")]
		public BattlesModel(uint[] userLevelsForNotification, IGame game, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x0000E010 File Offset: 0x0000C210
		// (set) Token: 0x06004BFD RID: 19453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F53")]
		public int NotificationCount
		{
			[Token(Token = "0x6004BFC")]
			[Address(RVA = "0x9A40", Offset = "0x9A40", VA = "0x9A40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004BFD")]
			[Address(RVA = "0x9A41", Offset = "0x9A41", VA = "0x9A41")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x9A42", Offset = "0x9A42", VA = "0x9A42")]
		public bool IsLickedByRestrictions(uint uiElementId, out IEnumerable<RestrictionInfo> ReasonRestrictions)
		{
			return default(bool);
		}

		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		[FieldOffset(Offset = "0x10")]
		public readonly IRequirementValidator RequirementValidator;

		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		[FieldOffset(Offset = "0x14")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		[FieldOffset(Offset = "0x18")]
		public readonly uint[] UserLevelsForNotification;
	}
}
