using System;
using AssetContent;
using Gameplay.Announcements.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Announcements.View
{
	// Token: 0x02000DA0 RID: 3488
	[Token(Token = "0x2000DA0")]
	public class AnnouncementsView : AbstractDataRenderer<AnnouncementsData>
	{
		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001150")]
		public Button ActivityButton
		{
			[Token(Token = "0x6005543")]
			[Address(RVA = "0xA2E4", Offset = "0xA2E4", VA = "0xA2E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005544")]
		[Address(RVA = "0xA2E5", Offset = "0xA2E5", VA = "0xA2E5", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005545")]
		[Address(RVA = "0xA2E6", Offset = "0xA2E6", VA = "0xA2E6")]
		public AnnouncementsView()
		{
		}

		// Token: 0x04002E28 RID: 11816
		[Token(Token = "0x4002E28")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameImage _background;

		// Token: 0x04002E29 RID: 11817
		[Token(Token = "0x4002E29")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImage _image;

		// Token: 0x04002E2A RID: 11818
		[Token(Token = "0x4002E2A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _btnLabel;

		// Token: 0x04002E2B RID: 11819
		[Token(Token = "0x4002E2B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002E2C RID: 11820
		[Token(Token = "0x4002E2C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _activityButton;
	}
}
