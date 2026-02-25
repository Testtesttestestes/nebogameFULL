using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Animations
{
	// Token: 0x0200127B RID: 4731
	[Token(Token = "0x200127B")]
	[RequireComponent(typeof(SkeletonAnimation))]
	public class GameSpineAnimation : MonoBehaviour, IGameAnimation, IPointerClickHandler, IEventSystemHandler, IGrayscalable, IAlpha
	{
		// Token: 0x140002FF RID: 767
		// (add) Token: 0x0600705A RID: 28762 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600705B RID: 28763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FF")]
		public event Action<IGameAnimation> ClickEvent
		{
			[Token(Token = "0x600705A")]
			[Address(RVA = "0xBA9F", Offset = "0xBA9F", VA = "0xBA9F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600705B")]
			[Address(RVA = "0xBAA0", Offset = "0xBAA0", VA = "0xBAA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x0600705C RID: 28764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016EE")]
		public MeshRenderer MeshRenderer
		{
			[Token(Token = "0x600705C")]
			[Address(RVA = "0xBAA1", Offset = "0xBAA1", VA = "0xBAA1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x0600705D RID: 28765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016EF")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x600705D")]
			[Address(RVA = "0xBAA2", Offset = "0xBAA2", VA = "0xBAA2", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x0600705E RID: 28766 RVA: 0x00014670 File Offset: 0x00012870
		// (set) Token: 0x0600705F RID: 28767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F0")]
		public bool IsInit
		{
			[Token(Token = "0x600705E")]
			[Address(RVA = "0xBAA3", Offset = "0xBAA3", VA = "0xBAA3")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600705F")]
			[Address(RVA = "0xBAA4", Offset = "0xBAA4", VA = "0xBAA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06007060 RID: 28768 RVA: 0x00014688 File Offset: 0x00012888
		// (set) Token: 0x06007061 RID: 28769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F1")]
		public int SortingLayerId
		{
			[Token(Token = "0x6007060")]
			[Address(RVA = "0xBAA5", Offset = "0xBAA5", VA = "0xBAA5", Slot = "11")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007061")]
			[Address(RVA = "0xBAA6", Offset = "0xBAA6", VA = "0xBAA6", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x14000300 RID: 768
		// (add) Token: 0x06007062 RID: 28770 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007063 RID: 28771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000300")]
		public event Action<IGameAnimation> CompleteEvent
		{
			[Token(Token = "0x6007062")]
			[Address(RVA = "0xBAA7", Offset = "0xBAA7", VA = "0xBAA7", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007063")]
			[Address(RVA = "0xBAA8", Offset = "0xBAA8", VA = "0xBAA8", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06007064 RID: 28772 RVA: 0x000146A0 File Offset: 0x000128A0
		// (set) Token: 0x06007065 RID: 28773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F2")]
		public bool Interactable
		{
			[Token(Token = "0x6007064")]
			[Address(RVA = "0xBAA9", Offset = "0xBAA9", VA = "0xBAA9", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007065")]
			[Address(RVA = "0xBAAA", Offset = "0xBAAA", VA = "0xBAAA", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06007066 RID: 28774 RVA: 0x000146B8 File Offset: 0x000128B8
		// (set) Token: 0x06007067 RID: 28775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F3")]
		public int SortingOrder
		{
			[Token(Token = "0x6007066")]
			[Address(RVA = "0xBAAB", Offset = "0xBAAB", VA = "0xBAAB", Slot = "13")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007067")]
			[Address(RVA = "0xBAAC", Offset = "0xBAAC", VA = "0xBAAC", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x06007068 RID: 28776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007068")]
		[Address(RVA = "0xBAAD", Offset = "0xBAAD", VA = "0xBAAD")]
		private void Awake()
		{
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007069")]
		[Address(RVA = "0xBAAE", Offset = "0xBAAE", VA = "0xBAAE")]
		public void Init()
		{
		}

		// Token: 0x0600706A RID: 28778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706A")]
		[Address(RVA = "0xBAAF", Offset = "0xBAAF", VA = "0xBAAF", Slot = "16")]
		public void Play(bool loop)
		{
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x000146D0 File Offset: 0x000128D0
		[Token(Token = "0x600706B")]
		[Address(RVA = "0xBAB0", Offset = "0xBAB0", VA = "0xBAB0")]
		public float GetFirstAnimationDuration()
		{
			return 0f;
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600706C")]
		[Address(RVA = "0xBAB1", Offset = "0xBAB1", VA = "0xBAB1")]
		private string GetFirstAnimationName()
		{
			return null;
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706D")]
		[Address(RVA = "0xBAB2", Offset = "0xBAB2", VA = "0xBAB2")]
		private void AnimationStateOnComplete(TrackEntry trackEntry)
		{
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706E")]
		[Address(RVA = "0x1C32", Offset = "0x1C32", VA = "0x1C32", Slot = "17")]
		public void Stop()
		{
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600706F")]
		[Address(RVA = "0xBAB3", Offset = "0xBAB3", VA = "0xBAB3", Slot = "19")]
		public void Pause()
		{
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06007070 RID: 28784 RVA: 0x000146E8 File Offset: 0x000128E8
		// (set) Token: 0x06007071 RID: 28785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F4")]
		public bool Loop
		{
			[Token(Token = "0x6007070")]
			[Address(RVA = "0xBAB4", Offset = "0xBAB4", VA = "0xBAB4", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007071")]
			[Address(RVA = "0xBAB5", Offset = "0xBAB5", VA = "0xBAB5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007072")]
		[Address(RVA = "0xBAB6", Offset = "0xBAB6", VA = "0xBAB6", Slot = "18")]
		public void Play(string state, bool loop)
		{
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007073")]
		[Address(RVA = "0xBAB7", Offset = "0xBAB7", VA = "0xBAB7", Slot = "20")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007074")]
		[Address(RVA = "0xBAB8", Offset = "0xBAB8", VA = "0xBAB8", Slot = "21")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007075")]
		[Address(RVA = "0xBAB9", Offset = "0xBAB9", VA = "0xBAB9", Slot = "22")]
		public void SetAlpha(float value)
		{
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007076")]
		[Address(RVA = "0xBABA", Offset = "0xBABA", VA = "0xBABA")]
		public GameSpineAnimation()
		{
		}

		// Token: 0x04003A98 RID: 15000
		[Token(Token = "0x4003A98")]
		[FieldOffset(Offset = "0x10")]
		private SkeletonAnimation _skeletonAnimation;

		// Token: 0x04003A99 RID: 15001
		[Token(Token = "0x4003A99")]
		[FieldOffset(Offset = "0x14")]
		private MeshRenderer _meshRenderer;

		// Token: 0x04003A9A RID: 15002
		[Token(Token = "0x4003A9A")]
		[FieldOffset(Offset = "0x18")]
		private PolygonCollider2D _polygonCollider2D;

		// Token: 0x04003A9B RID: 15003
		[Token(Token = "0x4003A9B")]
		[FieldOffset(Offset = "0x1C")]
		private GrayscaleSpine _grayscale;

		// Token: 0x04003A9C RID: 15004
		[Token(Token = "0x4003A9C")]
		[FieldOffset(Offset = "0x20")]
		private AlphaSpine _alpha;

		// Token: 0x04003A9E RID: 15006
		[Token(Token = "0x4003A9E")]
		[FieldOffset(Offset = "0x28")]
		private int _sortingLayerId;

		// Token: 0x04003A9F RID: 15007
		[Token(Token = "0x4003A9F")]
		[FieldOffset(Offset = "0x2C")]
		private MaterialType _materialType;

		// Token: 0x04003AA2 RID: 15010
		[Token(Token = "0x4003AA2")]
		[FieldOffset(Offset = "0x38")]
		private bool _interactable;

		// Token: 0x04003AA3 RID: 15011
		[Token(Token = "0x4003AA3")]
		[FieldOffset(Offset = "0x3C")]
		private int _sortingOrder;
	}
}
