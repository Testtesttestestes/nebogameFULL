using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Notifications.Model
{
	// Token: 0x020011AB RID: 4523
	[Token(Token = "0x20011AB")]
	public class GameNotificationsModel : AbstractModel
	{
		// Token: 0x06006B79 RID: 27513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B79")]
		[Address(RVA = "0xB677", Offset = "0xB677", VA = "0xB677")]
		public GameNotificationsModel(UserData user, Dictionaries dictionaries)
		{
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B7A")]
		[Address(RVA = "0xB678", Offset = "0xB678", VA = "0xB678")]
		private void Init(Dictionaries dictionaries)
		{
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B7B")]
		[Address(RVA = "0x220F", Offset = "0x220F", VA = "0x220F")]
		private List<NotificationGroupData> GetNotificationGroups(Dictionaries dictionaries, uint categoryId)
		{
			return null;
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B7C")]
		[Address(RVA = "0x2220", Offset = "0x2220", VA = "0x2220")]
		public NotificationGroupData GetGroup(uint groupId)
		{
			return null;
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x00013D58 File Offset: 0x00011F58
		[Token(Token = "0x6006B7D")]
		[Address(RVA = "0x1EC1", Offset = "0x1EC1", VA = "0x1EC1")]
		public bool IsGroupEnabled(uint groupId)
		{
			return default(bool);
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x6006B7E")]
		[Address(RVA = "0xB679", Offset = "0xB679", VA = "0xB679")]
		public bool IsNotificationEnabled(uint notificationId)
		{
			return default(bool);
		}

		// Token: 0x040038BE RID: 14526
		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0xC")]
		public List<NotificationCategoryData> NotificationCategories;

		// Token: 0x040038BF RID: 14527
		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, uint> GroupByNotificationId;

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x14")]
		public List<uint> AllGroupIds;
	}
}
