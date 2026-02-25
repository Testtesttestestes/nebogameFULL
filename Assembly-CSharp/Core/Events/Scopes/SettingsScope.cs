using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data.User;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001025 RID: 4133
	[Token(Token = "0x2001025")]
	public class SettingsScope : AbstractEventBusScope
	{
		// Token: 0x060061A4 RID: 24996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A4")]
		[Address(RVA = "0xADCF", Offset = "0xADCF", VA = "0xADCF", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A5")]
		[Address(RVA = "0xADD0", Offset = "0xADD0", VA = "0xADD0")]
		public SettingsScope()
		{
		}

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x8")]
		public Action<SettingsScope.SettingsEventArgs> SettingsInitializedEvent;

		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		[FieldOffset(Offset = "0xC")]
		public Action<SettingsScope.SettingsEventArgs> SettingsChangedEvent;

		// Token: 0x02001026 RID: 4134
		[Token(Token = "0x2001026")]
		public class SettingsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001375 RID: 4981
			// (get) Token: 0x060061A6 RID: 24998 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001375")]
			public UserSettings UserSettings
			{
				[Token(Token = "0x60061A6")]
				[Address(RVA = "0xADD1", Offset = "0xADD1", VA = "0xADD1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060061A7 RID: 24999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061A7")]
			[Address(RVA = "0xADD2", Offset = "0xADD2", VA = "0xADD2")]
			public SettingsEventArgs(App app, IGame game, UserSettings userSettings)
			{
			}
		}
	}
}
