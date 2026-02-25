using System;
using AssetContent;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.View.Milestone.Activity
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	public class ActivityView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06002BEF RID: 11247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0x7C80", Offset = "0x7C80", VA = "0x7C80")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085D")]
		public GameActivityData Data
		{
			[Token(Token = "0x6002BF0")]
			[Address(RVA = "0x7C81", Offset = "0x7C81", VA = "0x7C81")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BF1")]
			[Address(RVA = "0x7C82", Offset = "0x7C82", VA = "0x7C82")]
			set
			{
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0x7C83", Offset = "0x7C83", VA = "0x7C83")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF3")]
		[Address(RVA = "0x7C84", Offset = "0x7C84", VA = "0x7C84", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x7C85", Offset = "0x7C85", VA = "0x7C85")]
		public ActivityView()
		{
		}

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UnityEvent<GameActivityData> ClickEvent;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x1C")]
		private GameActivityData _data;
	}
}
