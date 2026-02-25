using System;
using Il2CppDummyDll;

namespace Core.Data.User
{
	// Token: 0x020010C7 RID: 4295
	[Token(Token = "0x20010C7")]
	[Serializable]
	public class UserSettings
	{
		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600649C RID: 25756 RVA: 0x00013200 File Offset: 0x00011400
		[Token(Token = "0x17001454")]
		public virtual bool GuideEnabled
		{
			[Token(Token = "0x600649C")]
			[Address(RVA = "0xB085", Offset = "0xB085", VA = "0xB085", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649D")]
		[Address(RVA = "0xB086", Offset = "0xB086", VA = "0xB086")]
		public UserSettings()
		{
		}

		// Token: 0x040035B2 RID: 13746
		[Token(Token = "0x40035B2")]
		[FieldOffset(Offset = "0x8")]
		public bool soundEnabled;

		// Token: 0x040035B3 RID: 13747
		[Token(Token = "0x40035B3")]
		[FieldOffset(Offset = "0x9")]
		public bool musicEnabled;

		// Token: 0x040035B4 RID: 13748
		[Token(Token = "0x40035B4")]
		[FieldOffset(Offset = "0xA")]
		public bool CombatAnimationsEnabled;

		// Token: 0x040035B5 RID: 13749
		[Token(Token = "0x40035B5")]
		[FieldOffset(Offset = "0xB")]
		public bool CombatSpellAnimationsEnabled;

		// Token: 0x040035B6 RID: 13750
		[Token(Token = "0x40035B6")]
		[FieldOffset(Offset = "0xC")]
		public bool WorldMovementAnimationsEnabled;
	}
}
