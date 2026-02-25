using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class ToggleButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x140000CD RID: 205
		// (add) Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CD")]
		public event Action<ToggleButton> ClickEvent
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x5C4C", Offset = "0x5C4C", VA = "0x5C4C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x5C4D", Offset = "0x5C4D", VA = "0x5C4D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		public bool Selected
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x5C4E", Offset = "0x5C4E", VA = "0x5C4E")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x5C4F", Offset = "0x5C4F", VA = "0x5C4F")]
			set
			{
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x5C50", Offset = "0x5C50", VA = "0x5C50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x5C51", Offset = "0x5C51", VA = "0x5C51", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x5C52", Offset = "0x5C52", VA = "0x5C52", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x5C53", Offset = "0x5C53", VA = "0x5C53", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x5C54", Offset = "0x5C54", VA = "0x5C54")]
		public ToggleButton()
		{
		}

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _image;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Sprite _spriteDefault;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _spriteSelected;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x1C")]
		private bool _selected;
	}
}
