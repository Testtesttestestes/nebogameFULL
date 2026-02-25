using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Notifications.Model
{
	// Token: 0x020011AD RID: 4525
	[Token(Token = "0x20011AD")]
	public class NotificationCategoryData
	{
		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06006B83 RID: 27523 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006B84 RID: 27524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015EC")]
		public NotificationCategoryDic NotificationCategoryDic
		{
			[Token(Token = "0x6006B83")]
			[Address(RVA = "0xB67E", Offset = "0xB67E", VA = "0xB67E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006B84")]
			[Address(RVA = "0xB67F", Offset = "0xB67F", VA = "0xB67F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06006B85 RID: 27525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015ED")]
		public List<NotificationGroupData> Groups
		{
			[Token(Token = "0x6006B85")]
			[Address(RVA = "0xB680", Offset = "0xB680", VA = "0xB680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x170015EE")]
		public uint SortOrder
		{
			[Token(Token = "0x6006B86")]
			[Address(RVA = "0xB681", Offset = "0xB681", VA = "0xB681")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06006B87 RID: 27527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015EF")]
		public string Title
		{
			[Token(Token = "0x6006B87")]
			[Address(RVA = "0xB682", Offset = "0xB682", VA = "0xB682")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B88")]
		[Address(RVA = "0x2210", Offset = "0x2210", VA = "0x2210")]
		public NotificationCategoryData(NotificationCategoryDic notificationCategoryDic, List<NotificationGroupData> groups)
		{
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[Token(Token = "0x6006B89")]
		[Address(RVA = "0xB683", Offset = "0xB683", VA = "0xB683")]
		public bool TryGetGroup(uint groupId, out NotificationGroupData result)
		{
			return default(bool);
		}

		// Token: 0x040038C6 RID: 14534
		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, NotificationGroupData> _groupsDictionary;
	}
}
