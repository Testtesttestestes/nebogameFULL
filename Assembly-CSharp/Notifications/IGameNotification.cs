using System;
using Il2CppDummyDll;

namespace Notifications
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	public interface IGameNotification
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000777 RID: 1911
		// (set) Token: 0x06000778 RID: 1912
		[Token(Token = "0x170000CE")]
		int? Id { [Token(Token = "0x6000777")] get; [Token(Token = "0x6000778")] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000779 RID: 1913
		// (set) Token: 0x0600077A RID: 1914
		[Token(Token = "0x170000CF")]
		string Title { [Token(Token = "0x6000779")] get; [Token(Token = "0x600077A")] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600077B RID: 1915
		// (set) Token: 0x0600077C RID: 1916
		[Token(Token = "0x170000D0")]
		string Body { [Token(Token = "0x600077B")] get; [Token(Token = "0x600077C")] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600077D RID: 1917
		// (set) Token: 0x0600077E RID: 1918
		[Token(Token = "0x170000D1")]
		string Subtitle { [Token(Token = "0x600077D")] get; [Token(Token = "0x600077E")] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600077F RID: 1919
		// (set) Token: 0x06000780 RID: 1920
		[Token(Token = "0x170000D2")]
		string Data { [Token(Token = "0x600077F")] get; [Token(Token = "0x6000780")] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000781 RID: 1921
		// (set) Token: 0x06000782 RID: 1922
		[Token(Token = "0x170000D3")]
		string Group { [Token(Token = "0x6000781")] get; [Token(Token = "0x6000782")] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000783 RID: 1923
		// (set) Token: 0x06000784 RID: 1924
		[Token(Token = "0x170000D4")]
		int? BadgeNumber { [Token(Token = "0x6000783")] get; [Token(Token = "0x6000784")] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000785 RID: 1925
		// (set) Token: 0x06000786 RID: 1926
		[Token(Token = "0x170000D5")]
		bool ShouldAutoCancel { [Token(Token = "0x6000785")] get; [Token(Token = "0x6000786")] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000787 RID: 1927
		// (set) Token: 0x06000788 RID: 1928
		[Token(Token = "0x170000D6")]
		DateTime? DeliveryTime { [Token(Token = "0x6000787")] get; [Token(Token = "0x6000788")] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000789 RID: 1929
		[Token(Token = "0x170000D7")]
		bool Scheduled { [Token(Token = "0x6000789")] get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600078A RID: 1930
		// (set) Token: 0x0600078B RID: 1931
		[Token(Token = "0x170000D8")]
		string SmallIcon { [Token(Token = "0x600078A")] get; [Token(Token = "0x600078B")] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600078C RID: 1932
		// (set) Token: 0x0600078D RID: 1933
		[Token(Token = "0x170000D9")]
		string LargeIcon { [Token(Token = "0x600078C")] get; [Token(Token = "0x600078D")] set; }
	}
}
