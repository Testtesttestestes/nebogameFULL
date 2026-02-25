using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AssetContent.Loaders
{
	// Token: 0x02000E35 RID: 3637
	[Token(Token = "0x2000E35")]
	[RequireComponent(typeof(PolygonCollider2D))]
	[DisallowMultipleComponent]
	public class GameSpriteRendererLoaderInteractable : GameSpriteRendererLoader, IPointerClickHandler, IEventSystemHandler, IBoundsProvider, IGrayscalable
	{
		// Token: 0x14000219 RID: 537
		// (add) Token: 0x0600591E RID: 22814 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600591F RID: 22815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000219")]
		public event Action ClickEvent
		{
			[Token(Token = "0x600591E")]
			[Address(RVA = "0xA671", Offset = "0xA671", VA = "0xA671")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600591F")]
			[Address(RVA = "0xA672", Offset = "0xA672", VA = "0xA672")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06005920 RID: 22816 RVA: 0x0000FD68 File Offset: 0x0000DF68
		// (set) Token: 0x06005921 RID: 22817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001228")]
		public bool Interactable
		{
			[Token(Token = "0x6005920")]
			[Address(RVA = "0xA673", Offset = "0xA673", VA = "0xA673")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005921")]
			[Address(RVA = "0x1DF9", Offset = "0x1DF9", VA = "0x1DF9")]
			set
			{
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001229")]
		protected PolygonCollider2D PolygonCollider2D
		{
			[Token(Token = "0x6005922")]
			[Address(RVA = "0xA674", Offset = "0xA674", VA = "0xA674")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005923")]
		[Address(RVA = "0xA675", Offset = "0xA675", VA = "0xA675", Slot = "10")]
		protected override void HandleSpriteChanged()
		{
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005924")]
		[Address(RVA = "0xA676", Offset = "0xA676", VA = "0xA676", Slot = "12")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06005925 RID: 22821 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x1700122A")]
		public Bounds Bounds
		{
			[Token(Token = "0x6005925")]
			[Address(RVA = "0xA677", Offset = "0xA677", VA = "0xA677", Slot = "13")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005926")]
		[Address(RVA = "0xA678", Offset = "0xA678", VA = "0xA678")]
		public GameSpriteRendererLoaderInteractable()
		{
		}

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x38")]
		private PolygonCollider2D _polygonCollider2D;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x3C")]
		private bool _interactable;
	}
}
