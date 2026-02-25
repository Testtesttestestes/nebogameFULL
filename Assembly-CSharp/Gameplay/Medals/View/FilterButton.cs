using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Medals.View
{
	// Token: 0x020005FD RID: 1533
	[Token(Token = "0x20005FD")]
	public class FilterButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x1400014F RID: 335
		// (add) Token: 0x06002536 RID: 9526 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002537 RID: 9527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014F")]
		public event Action<FilterButton> ClickEvent
		{
			[Token(Token = "0x6002536")]
			[Address(RVA = "0x767F", Offset = "0x767F", VA = "0x767F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002537")]
			[Address(RVA = "0x7680", Offset = "0x7680", VA = "0x7680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002538")]
		[Address(RVA = "0x7681", Offset = "0x7681", VA = "0x7681")]
		private void Awake()
		{
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002539")]
		[Address(RVA = "0x7682", Offset = "0x7682", VA = "0x7682")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253A")]
		[Address(RVA = "0x7683", Offset = "0x7683", VA = "0x7683")]
		private void ClickedHandler()
		{
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x00007128 File Offset: 0x00005328
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FC")]
		public bool Selected
		{
			[Token(Token = "0x600253B")]
			[Address(RVA = "0x7684", Offset = "0x7684", VA = "0x7684")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600253C")]
			[Address(RVA = "0x7685", Offset = "0x7685", VA = "0x7685")]
			set
			{
			}
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x7686", Offset = "0x7686", VA = "0x7686", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x7687", Offset = "0x7687", VA = "0x7687", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x7688", Offset = "0x7688", VA = "0x7688", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x7689", Offset = "0x7689", VA = "0x7689")]
		public FilterButton()
		{
		}

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _defaultImagePath;

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private string _selectedImagePath;

		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameImage _imageOn;

		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x4001464")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _imageOff;

		// Token: 0x04001466 RID: 5222
		[Token(Token = "0x4001466")]
		[FieldOffset(Offset = "0x24")]
		private bool _selected;
	}
}
