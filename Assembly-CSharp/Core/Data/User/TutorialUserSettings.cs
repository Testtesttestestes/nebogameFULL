using System;
using Il2CppDummyDll;

namespace Core.Data.User
{
	// Token: 0x020010C8 RID: 4296
	[Token(Token = "0x20010C8")]
	public class TutorialUserSettings : UserSettings
	{
		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x0600649E RID: 25758 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x17001455")]
		public override bool GuideEnabled
		{
			[Token(Token = "0x600649E")]
			[Address(RVA = "0xB087", Offset = "0xB087", VA = "0xB087", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649F")]
		[Address(RVA = "0xB088", Offset = "0xB088", VA = "0xB088")]
		public TutorialUserSettings()
		{
		}
	}
}
