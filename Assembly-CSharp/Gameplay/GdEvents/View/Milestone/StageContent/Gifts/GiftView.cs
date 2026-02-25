using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Gifts
{
	// Token: 0x0200072C RID: 1836
	[Token(Token = "0x200072C")]
	public class GiftView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000161 RID: 353
		// (add) Token: 0x06002BDA RID: 11226 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002BDB RID: 11227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000161")]
		public event Action<SocialGiftDic> ClickEvent
		{
			[Token(Token = "0x6002BDA")]
			[Address(RVA = "0x7C6B", Offset = "0x7C6B", VA = "0x7C6B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002BDB")]
			[Address(RVA = "0x7C6C", Offset = "0x7C6C", VA = "0x7C6C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDC")]
		[Address(RVA = "0x7C6D", Offset = "0x7C6D", VA = "0x7C6D")]
		private void OnDestroy()
		{
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002BDD RID: 11229 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BDE RID: 11230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085A")]
		public SocialGiftDic Data
		{
			[Token(Token = "0x6002BDD")]
			[Address(RVA = "0x7C6E", Offset = "0x7C6E", VA = "0x7C6E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BDE")]
			[Address(RVA = "0x7C6F", Offset = "0x7C6F", VA = "0x7C6F")]
			set
			{
			}
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x7C70", Offset = "0x7C70", VA = "0x7C70")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x7C71", Offset = "0x7C71", VA = "0x7C71", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0x7C72", Offset = "0x7C72", VA = "0x7C72")]
		public GiftView()
		{
		}

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001807 RID: 6151
		[Token(Token = "0x4001807")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x1C")]
		private SocialGiftDic _data;
	}
}
