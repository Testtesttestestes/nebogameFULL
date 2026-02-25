using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.UserContextMenu;

namespace Gameplay.Boss.Model.ContextMenu
{
	// Token: 0x02000B9D RID: 2973
	[Token(Token = "0x2000B9D")]
	public class BossMenuContext : IBossMenuContext, IUserMenuContext
	{
		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060048B7 RID: 18615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED3")]
		public UserData User
		{
			[Token(Token = "0x60048B6")]
			[Address(RVA = "0x972F", Offset = "0x972F", VA = "0x972F", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60048B7")]
			[Address(RVA = "0x9730", Offset = "0x9730", VA = "0x9730", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED4")]
		public TeamData.AbstractTeamMember TeamMemberData
		{
			[Token(Token = "0x60048B8")]
			[Address(RVA = "0x9731", Offset = "0x9731", VA = "0x9731", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048B9")]
			[Address(RVA = "0x9732", Offset = "0x9732", VA = "0x9732", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x9733", Offset = "0x9733", VA = "0x9733")]
		public BossMenuContext()
		{
		}
	}
}
