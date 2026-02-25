using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Tabs
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	public class CategoryTabBarItemView : MonoBehaviour, ITabBarItemView, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700015C")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x5DD5", Offset = "0x5DD5", VA = "0x5DD5")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DA")]
		public event Action<TabBarItemData> SelectEvent
		{
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x5DD6", Offset = "0x5DD6", VA = "0x5DD6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x5DD7", Offset = "0x5DD7", VA = "0x5DD7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015D")]
		public TabBarItemData Data
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x5DD8", Offset = "0x5DD8", VA = "0x5DD8", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x5DD9", Offset = "0x5DD9", VA = "0x5DD9", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700015E")]
		public GameObject GameObject
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x5DDA", Offset = "0x5DDA", VA = "0x5DDA", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015F")]
		public bool Selected
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x5DDB", Offset = "0x5DDB", VA = "0x5DDB", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x5DDC", Offset = "0x5DDC", VA = "0x5DDC", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x5DDD", Offset = "0x5DDD", VA = "0x5DDD", Slot = "11")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x5DDE", Offset = "0x5DDE", VA = "0x5DDE")]
		public CategoryTabBarItemView()
		{
		}

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _label;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Image _image;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _fontColorSelected;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _fontColorDefault;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _spriteDefault;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Sprite _spriteSelected;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x40")]
		private IGuideTarget _guideTarget;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x48")]
		private TabBarItemData _data;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x4C")]
		private bool _selected;
	}
}
