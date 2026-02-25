using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Core.Gameplay.Managers.Notifications.View
{
	// Token: 0x020011A8 RID: 4520
	[Token(Token = "0x20011A8")]
	public class NotificationSettingsView : AbstractDataRenderer<List<NotificationCategoryData>>
	{
		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x00013D40 File Offset: 0x00011F40
		[Token(Token = "0x170015E6")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6006B6D")]
			[Address(RVA = "0xB66B", Offset = "0xB66B", VA = "0xB66B", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6E")]
		[Address(RVA = "0xB66C", Offset = "0xB66C", VA = "0xB66C", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6F")]
		[Address(RVA = "0xB66D", Offset = "0xB66D", VA = "0xB66D")]
		public NotificationSettingsView()
		{
		}

		// Token: 0x040038B6 RID: 14518
		[Token(Token = "0x40038B6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private NotificationCategorySettingsView _categoryPrefab;

		// Token: 0x040038B7 RID: 14519
		[Token(Token = "0x40038B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;
	}
}
