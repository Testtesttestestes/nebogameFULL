using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Clans.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Clan.Model
{
	// Token: 0x02000DEF RID: 3567
	[Token(Token = "0x2000DEF")]
	public class ClanAccountModel : AbstractModel
	{
		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005711 RID: 22289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C0")]
		public ClansModel ClansModel
		{
			[Token(Token = "0x6005710")]
			[Address(RVA = "0xA48C", Offset = "0xA48C", VA = "0xA48C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005711")]
			[Address(RVA = "0xA48D", Offset = "0xA48D", VA = "0xA48D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005712")]
		[Address(RVA = "0xA48E", Offset = "0xA48E", VA = "0xA48E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005713")]
		[Address(RVA = "0xA48F", Offset = "0xA48F", VA = "0xA48F")]
		public ClanAccountModel(ClanAccountGroup accountGroup, ClansModel clansModel, UserData user)
		{
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005715 RID: 22293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C1")]
		public ClanAccountGroup AccountGroup
		{
			[Token(Token = "0x6005714")]
			[Address(RVA = "0xA490", Offset = "0xA490", VA = "0xA490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005715")]
			[Address(RVA = "0xA491", Offset = "0xA491", VA = "0xA491")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C2")]
		public ClanAccount CurrentSelected
		{
			[Token(Token = "0x6005716")]
			[Address(RVA = "0xA492", Offset = "0xA492", VA = "0xA492")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005717")]
			[Address(RVA = "0xA493", Offset = "0xA493", VA = "0xA493")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
