using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Notifications.Model
{
	// Token: 0x020011AF RID: 4527
	[Token(Token = "0x20011AF")]
	public class NotificationGroupData
	{
		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06006B8D RID: 27533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015F0")]
		public NotificationGroupDic GroupDic
		{
			[Token(Token = "0x6006B8D")]
			[Address(RVA = "0xB687", Offset = "0xB687", VA = "0xB687")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06006B8E RID: 27534 RVA: 0x00013E00 File Offset: 0x00012000
		[Token(Token = "0x170015F1")]
		public uint SortOrder
		{
			[Token(Token = "0x6006B8E")]
			[Address(RVA = "0xB688", Offset = "0xB688", VA = "0xB688")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06006B8F RID: 27535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015F2")]
		public string Title
		{
			[Token(Token = "0x6006B8F")]
			[Address(RVA = "0xB689", Offset = "0xB689", VA = "0xB689")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002C0 RID: 704
		// (add) Token: 0x06006B90 RID: 27536 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B91 RID: 27537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C0")]
		public event Action<NotificationGroupData> GroupEnabledChangedEvent
		{
			[Token(Token = "0x6006B90")]
			[Address(RVA = "0xB68A", Offset = "0xB68A", VA = "0xB68A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B91")]
			[Address(RVA = "0xB68B", Offset = "0xB68B", VA = "0xB68B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06006B92 RID: 27538 RVA: 0x00013E18 File Offset: 0x00012018
		// (set) Token: 0x06006B93 RID: 27539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015F3")]
		public bool IsGroupEnabled
		{
			[Token(Token = "0x6006B92")]
			[Address(RVA = "0xB68C", Offset = "0xB68C", VA = "0xB68C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006B93")]
			[Address(RVA = "0xB68D", Offset = "0xB68D", VA = "0xB68D")]
			set
			{
			}
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B94")]
		[Address(RVA = "0xB68E", Offset = "0xB68E", VA = "0xB68E")]
		public NotificationGroupData(NotificationGroupDic groupDic)
		{
		}

		// Token: 0x040038CB RID: 14539
		[Token(Token = "0x40038CB")]
		[FieldOffset(Offset = "0x10")]
		private bool _isGroupEnabled;
	}
}
