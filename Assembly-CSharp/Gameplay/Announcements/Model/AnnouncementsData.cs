using System;
using Il2CppDummyDll;
using Protocol.Announcements;
using Protocol.Dic;

namespace Gameplay.Announcements.Model
{
	// Token: 0x02000DA3 RID: 3491
	[Token(Token = "0x2000DA3")]
	public class AnnouncementsData
	{
		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x0600554C RID: 21836 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
		[Token(Token = "0x17001153")]
		public ulong Id
		{
			[Token(Token = "0x600554C")]
			[Address(RVA = "0xA2ED", Offset = "0xA2ED", VA = "0xA2ED")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600554D")]
		[Address(RVA = "0xA2EE", Offset = "0xA2EE", VA = "0xA2EE")]
		public AnnouncementsData(AnnouncementsDic dic, Announcement info)
		{
		}

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x8")]
		public readonly AnnouncementsDic Dic;

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0xC")]
		public readonly Announcement Info;
	}
}
