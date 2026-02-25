using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	public class VisitorItemRenderer : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x140001A5 RID: 421
		// (add) Token: 0x0600438D RID: 17293 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600438E RID: 17294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A5")]
		public event EventHandler<ChatVisitorData> ClickEvent
		{
			[Token(Token = "0x600438D")]
			[Address(RVA = "0x9241", Offset = "0x9241", VA = "0x9241")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600438E")]
			[Address(RVA = "0x9242", Offset = "0x9242", VA = "0x9242")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438F")]
		[Address(RVA = "0x9243", Offset = "0x9243", VA = "0x9243")]
		private void Awake()
		{
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004390")]
		[Address(RVA = "0x9244", Offset = "0x9244", VA = "0x9244")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		// (set) Token: 0x06004392 RID: 17298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D51")]
		public int Index
		{
			[Token(Token = "0x6004391")]
			[Address(RVA = "0x9245", Offset = "0x9245", VA = "0x9245")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004392")]
			[Address(RVA = "0x9246", Offset = "0x9246", VA = "0x9246")]
			set
			{
			}
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004393")]
		[Address(RVA = "0x9247", Offset = "0x9247", VA = "0x9247")]
		private void AttackButtonClickedEventHandler()
		{
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004394")]
		[Address(RVA = "0x9248", Offset = "0x9248", VA = "0x9248")]
		private void HandleIndexChanged()
		{
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004396 RID: 17302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D52")]
		public ChatVisitorData Data
		{
			[Token(Token = "0x6004395")]
			[Address(RVA = "0x9249", Offset = "0x9249", VA = "0x9249")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004396")]
			[Address(RVA = "0x924A", Offset = "0x924A", VA = "0x924A")]
			set
			{
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D53")]
		public string Title
		{
			[Token(Token = "0x6004397")]
			[Address(RVA = "0x924B", Offset = "0x924B", VA = "0x924B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004398")]
			[Address(RVA = "0x924C", Offset = "0x924C", VA = "0x924C")]
			set
			{
			}
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004399")]
		[Address(RVA = "0x924D", Offset = "0x924D", VA = "0x924D")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439A")]
		[Address(RVA = "0x924E", Offset = "0x924E", VA = "0x924E")]
		public void DataUpdated()
		{
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439B")]
		[Address(RVA = "0x924F", Offset = "0x924F", VA = "0x924F", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439C")]
		[Address(RVA = "0x9250", Offset = "0x9250", VA = "0x9250", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439D")]
		[Address(RVA = "0x9251", Offset = "0x9251", VA = "0x9251", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439E")]
		[Address(RVA = "0x9252", Offset = "0x9252", VA = "0x9252")]
		public VisitorItemRenderer()
		{
		}

		// Token: 0x0400253A RID: 9530
		[Token(Token = "0x400253A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _miscIcon;

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImageLoader _cultIcon;

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _titleField;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _levelField;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _background;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _notEvenBackgroundSprite;

		// Token: 0x04002540 RID: 9536
		[Token(Token = "0x4002540")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _evenBackgroundSprite;

		// Token: 0x04002541 RID: 9537
		[Token(Token = "0x4002541")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _moderatorIconSprite;

		// Token: 0x04002542 RID: 9538
		[Token(Token = "0x4002542")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _visitorBannedIconSprite;

		// Token: 0x04002543 RID: 9539
		[Token(Token = "0x4002543")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _attackButton;

		// Token: 0x04002544 RID: 9540
		[Token(Token = "0x4002544")]
		[FieldOffset(Offset = "0x38")]
		private int _index;

		// Token: 0x04002546 RID: 9542
		[Token(Token = "0x4002546")]
		[FieldOffset(Offset = "0x40")]
		private ChatVisitorData _data;

		// Token: 0x04002547 RID: 9543
		[Token(Token = "0x4002547")]
		[FieldOffset(Offset = "0x44")]
		private string _title;
	}
}
