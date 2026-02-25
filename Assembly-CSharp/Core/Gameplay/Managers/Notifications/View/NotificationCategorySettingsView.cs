using System;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Core.Gameplay.Managers.Notifications.View
{
	// Token: 0x020011A6 RID: 4518
	[Token(Token = "0x20011A6")]
	public class NotificationCategorySettingsView : AbstractDataRenderer<NotificationCategoryData>
	{
		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06006B64 RID: 27492 RVA: 0x00013D10 File Offset: 0x00011F10
		[Token(Token = "0x170015E4")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6006B64")]
			[Address(RVA = "0xB662", Offset = "0xB662", VA = "0xB662", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B65")]
		[Address(RVA = "0xB663", Offset = "0xB663", VA = "0xB663", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B66")]
		[Address(RVA = "0xB664", Offset = "0xB664", VA = "0xB664")]
		public NotificationCategorySettingsView()
		{
		}

		// Token: 0x040038B1 RID: 14513
		[Token(Token = "0x40038B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private NotificationGroupsSettingsView _groupPrefab;

		// Token: 0x040038B2 RID: 14514
		[Token(Token = "0x40038B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040038B3 RID: 14515
		[Token(Token = "0x40038B3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _container;
	}
}
