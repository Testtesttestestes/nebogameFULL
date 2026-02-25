using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x0200103D RID: 4157
	[Token(Token = "0x200103D")]
	public class UserScope : AbstractEventBusScope
	{
		// Token: 0x060061F4 RID: 25076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061F4")]
		[Address(RVA = "0xAE1F", Offset = "0xAE1F", VA = "0xAE1F", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061F5")]
		[Address(RVA = "0xAE20", Offset = "0xAE20", VA = "0xAE20")]
		public UserScope()
		{
		}

		// Token: 0x040034C0 RID: 13504
		[Token(Token = "0x40034C0")]
		[FieldOffset(Offset = "0x8")]
		public Action<UserScope.BaseUserEventArgs> BalanceChangedEvent;

		// Token: 0x040034C1 RID: 13505
		[Token(Token = "0x40034C1")]
		[FieldOffset(Offset = "0xC")]
		public Action<UserScope.BaseUserEventArgs> UserDataInitializedEvent;

		// Token: 0x040034C2 RID: 13506
		[Token(Token = "0x40034C2")]
		[FieldOffset(Offset = "0x10")]
		public Action<UserScope.BaseUserEventArgs> TriggersChangedEvent;

		// Token: 0x040034C3 RID: 13507
		[Token(Token = "0x40034C3")]
		[FieldOffset(Offset = "0x14")]
		public Action<UserScope.BaseUserEventArgs> NickChangedEvent;

		// Token: 0x040034C4 RID: 13508
		[Token(Token = "0x40034C4")]
		[FieldOffset(Offset = "0x18")]
		public Action<UserScope.BaseUserEventArgs> SkillsChangedEvent;

		// Token: 0x040034C5 RID: 13509
		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x1C")]
		public Action<UserScope.BaseUserEventArgs> CultChangedEvent;

		// Token: 0x040034C6 RID: 13510
		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0x20")]
		public Action<UserScope.BaseUserEventArgs> GenderChangedEvent;

		// Token: 0x040034C7 RID: 13511
		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x24")]
		public Action<UserScope.BaseUserEventArgs> AprChangedEvent;

		// Token: 0x040034C8 RID: 13512
		[Token(Token = "0x40034C8")]
		[FieldOffset(Offset = "0x28")]
		public Action<UserScope.BaseUserEventArgs> LevelChangedEvent;

		// Token: 0x040034C9 RID: 13513
		[Token(Token = "0x40034C9")]
		[FieldOffset(Offset = "0x2C")]
		public Action<UserScope.BaseUserEventArgs> ExpChangedEvent;

		// Token: 0x040034CA RID: 13514
		[Token(Token = "0x40034CA")]
		[FieldOffset(Offset = "0x30")]
		public Action<UserScope.BaseUserEventArgs> AccountsChangedEvent;

		// Token: 0x040034CB RID: 13515
		[Token(Token = "0x40034CB")]
		[FieldOffset(Offset = "0x34")]
		public Action<UserScope.BaseUserEventArgs> TreeLicenceCountChangedEvent;

		// Token: 0x040034CC RID: 13516
		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x38")]
		public Action<UserScope.BaseUserEventArgs> BuyTreeLicenceSuccessEvent;

		// Token: 0x040034CD RID: 13517
		[Token(Token = "0x40034CD")]
		[FieldOffset(Offset = "0x3C")]
		public Action<UserScope.BaseUserEventArgs> UserClanUpdatedEvent;

		// Token: 0x0200103E RID: 4158
		[Token(Token = "0x200103E")]
		public class BaseUserEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x170013A5 RID: 5029
			// (get) Token: 0x060061F6 RID: 25078 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060061F7 RID: 25079 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013A5")]
			public UserData UserData
			{
				[Token(Token = "0x60061F6")]
				[Address(RVA = "0xAE21", Offset = "0xAE21", VA = "0xAE21")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60061F7")]
				[Address(RVA = "0xAE22", Offset = "0xAE22", VA = "0xAE22")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060061F8 RID: 25080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061F8")]
			[Address(RVA = "0xAE23", Offset = "0xAE23", VA = "0xAE23")]
			public BaseUserEventArgs(App app, IGame game, UserData userData)
			{
			}
		}
	}
}
