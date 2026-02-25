using System;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Gameplay.Managers.Notifications.View
{
	// Token: 0x020011A7 RID: 4519
	[Token(Token = "0x20011A7")]
	public class NotificationGroupsSettingsView : AbstractDataRenderer<NotificationGroupData>
	{
		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x00013D28 File Offset: 0x00011F28
		[Token(Token = "0x170015E5")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6006B67")]
			[Address(RVA = "0xB665", Offset = "0xB665", VA = "0xB665", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B68")]
		[Address(RVA = "0xB666", Offset = "0xB666", VA = "0xB666", Slot = "10")]
		public override void Dispose()
		{
		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B69")]
		[Address(RVA = "0xB667", Offset = "0xB667", VA = "0xB667", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6A")]
		[Address(RVA = "0xB668", Offset = "0xB668", VA = "0xB668")]
		private void HandleToggleChanged(bool isOn)
		{
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6B")]
		[Address(RVA = "0xB669", Offset = "0xB669", VA = "0xB669", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6C")]
		[Address(RVA = "0xB66A", Offset = "0xB66A", VA = "0xB66A")]
		public NotificationGroupsSettingsView()
		{
		}

		// Token: 0x040038B4 RID: 14516
		[Token(Token = "0x40038B4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040038B5 RID: 14517
		[Token(Token = "0x40038B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _toggle;
	}
}
